﻿using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_HomePublicacoes : System.Web.UI.Page
{
    private void CarregaGv()
    {
        PublicacaoBD bd = new PublicacaoBD();
        DataSet ds = bd.SelectAllByStatusAndSalles();
        //verifica a quantidade de publicações no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {
            Publicacao publicacao = new Publicacao();
            {
               

                gvPublicacao.DataSource = ds.Tables[0].DefaultView;
                gvPublicacao.DataBind();

                lblMensagem.Text = "Existem " + quantidade + " classificados Ativos";
            }
        }
        else
        {
            lblMensagem.Text = "Nenhum classificado ativo!";
        }
    }
    private void Carregarpt()
    {
        PublicacaoBD bd = new PublicacaoBD();
        DataSet ds = bd.SelectAllByStatusAndEvent();
        //verifica a quantidade de publicações no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {
            Publicacao publicacao = new Publicacao();
            {
                rptPublicacoes.DataSource = ds.Tables[0].DefaultView;
                rptPublicacoes.DataBind();

                

                lblMensagem2.Text = "Existem " + quantidade + " Publicações Ativas";
            }
        }
        else
        {
            lblMensagem2.Text = "Nenhuma Publicação Ativa!";
        }
    }

    public static IPAddress GetIPAddress(string hostName)
    {
        Ping ping = new Ping();
        var replay = ping.Send(hostName);

        if (replay.Status == IPStatus.Success)
        {
            return replay.Address;
        }
        return null;
    }


    protected void Page_Load(object sender, EventArgs e)
    {
      

        if (!Page.IsPostBack)
        {
            
            
                Carregarpt();
            
                CarregaGv();
            
        }

      
            Ip ip = new Ip();
            string endereco = Convert.ToString(GetIPAddress(Dns.GetHostName()));
            ip.Endereco = endereco;
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy/MM/dd");
            ip.Data = Convert.ToDateTime(formattedTime);



        IpBD bd = new IpBD();
        Boolean ips = bd.Select(endereco, formattedTime);
        
        if (ips == true) { 
            bd.Insert(ip);

        }
    }



    protected void gvPublicacao_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            string foto = Convert.ToString(drv["pub_imagem"]);
            if (foto != string.Empty)
            {
                e.Row.Cells[0].Text = "<img src='http://localhost:54428/Upload/" + foto + "'style = 'width:50px' /> ";
            }
        }
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}