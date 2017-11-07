﻿using inso.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace inso.Repository
{
    public class PreguntaRepository : IPreguntaRepository
    {
        SqlConnection cn;
        Conexion con = new Conexion();
        public List<Pregunta> Reader()
        {
            cn = con.getCon();
            List<Pregunta> listpreg = new List<Pregunta>();
            SqlCommand cmd = new SqlCommand("GetPreguntas", cn);
            cmd.CommandType = CommandType.StoredProcedure; ;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cn.Open();
            sd.Fill(dt);
            cn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                listpreg.Add(new Pregunta
                {
                   pregunta = Convert.ToString(dr["pregunta"]),
                   opt1=Convert.ToString(dr["opt1"]),
                   opt2=Convert.ToString(dr["opt2"]),
                   opt3=Convert.ToString(dr["opt3"]),
                   opt4=Convert.ToString(dr["opt4"]),
                   contador=Convert.ToString(dr["contador"])
                });
            }

            return listpreg;

        }
    }
}