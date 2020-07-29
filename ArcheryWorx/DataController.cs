using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;

namespace ArcheryWorx
{
    public class DataControllerException : Exception
    {
        public DataControllerException(string message)
            : base(message)
        {
        }
    }

    class cDataController
    {
        const int SQLITE_OK = 0;
        const int SQLITE_ROW = 100;
        const int SQLITE_DONE = 101;
        const int SQLITE_INTEGER = 1;
        const int SQLITE_FLOAT = 2;
        const int SQLITE_TEXT = 3;
        const int SQLITE_BLOB = 4;
        const int SQLITE_NULL = 5;

        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_open", CallingConvention = CallingConvention.Cdecl)]
        static extern int sqlite3_open(string filename, out IntPtr db);

        //the opening of the sql database
        //[DllImport("sqlite3.dll", EntryPoint = "sqlite3_open")]
        //static extern int sqlite3_open(string filename, out IntPtr db);

        //closing sql database
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_close", CallingConvention = CallingConvention.Cdecl)]
            static extern int sqlite3_close(IntPtr db);

        //sqlite prepare
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_prepare_v2", CallingConvention = CallingConvention.Cdecl)]
            static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail);

        //sqlite stepping
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_step", CallingConvention = CallingConvention.Cdecl)]
            static extern int sqlite3_step(IntPtr stmHandle);

        //finalize
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_finalize", CallingConvention = CallingConvention.Cdecl)]
        static extern int sqlite3_finalize(IntPtr stmHandle);
        
        //error  handler
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_errmsg", CallingConvention = CallingConvention.Cdecl)]
            static extern string sqlite3_errmsg(IntPtr db);

        //Column count function
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_column_count", CallingConvention = CallingConvention.Cdecl)]
            static extern int sqlite3_column_count(IntPtr stmHandle);

        //Column origin name
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_column_origin_name", CallingConvention = CallingConvention.Cdecl)]
            static extern string sqlite3_column_origin_name(IntPtr stmHandle, int iCol);

        //
        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_column_type", CallingConvention = CallingConvention.Cdecl)]
            static extern int sqlite3_column_type(IntPtr stmHandle, int iCol);

        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_column_int",CallingConvention=CallingConvention.Cdecl)]
            static extern int sqlite3_column_int(IntPtr stmHandle, int iCol);

        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_column_text", CallingConvention = CallingConvention.Cdecl)]
            static extern string sqlite3_column_text(IntPtr stmHandle, int iCol);

        [DllImport("sqlite3.dll", EntryPoint = "sqlite3_column_double", CallingConvention = CallingConvention.Cdecl)]
            static extern double sqlite3_column_double(IntPtr stmHandle, int iCol);

        private IntPtr _db;
        private bool _open = false;

        public void OpenDatabase(string path)
        {
            if (sqlite3_open(path, out _db) != SQLITE_OK)
                throw new DataControllerException("Could not open database file: " + path);

            _open = true;
        }

        public void CloseDatabase()
        {
            if (_open)
                sqlite3_close(_db);

            _open = false;
        }

        public void ExecuteNonReturnQuery(string query)
        {
            if (!_open) 
                throw new DataControllerException("SQLite database is not open.");

            //prepare the statement
            IntPtr stmHandle = Prepare(query);

            if (sqlite3_step(stmHandle) != SQLITE_DONE)
                throw new DataControllerException("Could not execute SQL statement.");

            Finalize(stmHandle);
        }    
        
        public DataTable ExecuteQuery(string query)
        {
            if (!_open)
                throw new DataControllerException("SQLite database is not open.");

            //preparing the statement.
            IntPtr stmHandle = Prepare(query);

            //get the number of returned columns
            int columnCount = sqlite3_column_count(stmHandle);

            //create datatable and columns
            DataTable dTable = new DataTable();
            
            for (int i = 0; i < columnCount; i++)
            {
                //random exception... dunno why :(
                dTable.Columns.Add(sqlite3_column_origin_name(stmHandle, i));
            }
            //populate database
            while (sqlite3_step(stmHandle) == SQLITE_ROW)
            {
                object[] row = new object[columnCount];

                for (int i = 0; i < columnCount; i++)
                {
                    switch (sqlite3_column_type(stmHandle, i))
                    {
                        case SQLITE_INTEGER:
                            row[i] = sqlite3_column_int(stmHandle, i);
                            break;
                        case SQLITE_TEXT:
                            row[i] = sqlite3_column_text(stmHandle, i);
                            break;
                        case SQLITE_FLOAT:
                            row[i] = sqlite3_column_double(stmHandle, i);
                            break;
                    }
                }
                dTable.Rows.Add(row);
            }
            
            Finalize(stmHandle);
            return dTable;
        }

        private IntPtr Prepare(string query)
        {
            IntPtr stmHandle;

            if (sqlite3_prepare_v2(_db, query, query.Length, out stmHandle, IntPtr.Zero) != SQLITE_OK)
                throw new DataControllerException(sqlite3_errmsg(_db));
            return stmHandle;
        }

        private void Finalize(IntPtr stmHandle)
        {
            if (sqlite3_finalize(stmHandle) != SQLITE_OK)
                throw new DataControllerException("Could not finalize the SQL statement.");
        }
    }
}