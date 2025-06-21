﻿using MySqlConnector;
using System.Data;

namespace DatabaseAccessController
{
        public class dboDatabaseController
        {
            private String connectionString { get; set; }

            public dboDatabaseController(string connectionString)
            {
                this.connectionString = connectionString;
            }


            public DataTable GetData(String sqlCmd)
            {
                // Create the connection (and be sure to dispose it at the end)
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection to the database. 
                        // This is the first critical step in the process.
                        conn.Open();
                        MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, conn);
                        DataTable dt = new DataTable();
                        adr.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                        //log the error 
                    }
                }
            }
            public int BatchUpdate(String sqlCmd)
            {
                // Create the connection (and be sure to dispose it at the end)
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection to the database. 
                        // This is the first critical step in the process.
                        // If we cannot reach the db then we have connectivity problems
                        conn.Open();

                        int updatedRows = 0;

                        // Execute the batch query
                        using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                        {
                            updatedRows = cmd.ExecuteNonQuery();
                        }

                        return updatedRows;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                        // We should log the error somewhere, 
                        // for this example let's just show a message
                        //MessageBox.Show("ERROR:" + ex.Message);
                    }
                }
            }


        }
    }
