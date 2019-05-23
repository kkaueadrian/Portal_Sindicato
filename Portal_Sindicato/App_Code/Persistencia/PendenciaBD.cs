﻿using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PendenciaBD
/// </summary>
public class PendenciaBD
{
    public bool Insert(Pendencia pendencia)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO pen_pendencia(pen_tipo, pen_documento, pes_codigo) VALUES (?tipo, ?documento, ?associado)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?tipo", pendencia.Tipo));
        objCommand.Parameters.Add(Mapped.Parameter("?documento", pendencia.Documento));
        objCommand.Parameters.Add(Mapped.Parameter("?associado", pendencia.Associado.Codigo));
        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }

    public DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
       
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    public Pendencia SelectSpecific(int id)
    {
        Pendencia obj = null;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia WHERE pes_codigo = ?codigo", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            obj = new Pendencia();
            obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
            obj.Tipo = Convert.ToString(objDataReader["pen_tipo"]);
            obj.Documento = Convert.ToString(objDataReader["pen_documento"]);

        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return obj;
    }
    //select
    public Pendencia Select(int id)
    {
        Pendencia obj = null;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia WHERE pen_codigo = ?codigo", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            obj = new Pendencia();
            obj.Codigo = Convert.ToInt32(objDataReader["pen_codigo"]);
            obj.Tipo = Convert.ToString(objDataReader["pen_tipo"]);

        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return obj;
    }

    public PendenciaBD()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}