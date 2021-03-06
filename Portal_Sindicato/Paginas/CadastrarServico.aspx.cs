﻿using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_CadastrarServico : System.Web.UI.Page
{
    
    private void CarregaSetores()
    {
        SetorBD bd = new SetorBD();
        DataSet ds = bd.SelectAll();
        ddlSetor.DataSource = ds.Tables[0].DefaultView;
        ddlSetor.DataTextField = "set_tipo";
        ddlSetor.DataValueField = "set_codigo";
        ddlSetor.DataBind();
        ddlSetor.Items.Insert(0, "Selecione");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //carrega somente a primeira vez
        if (!Page.IsPostBack)
        {
            CarregaSetores();
            ddlSetor.Focus();
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        

        SetorBD setorbd = new SetorBD();
        Setor setor = setorbd.Select(Convert.ToInt32(ddlSetor.SelectedItem.Value));

        Servico servico = new Servico();
        servico.Descricao = txtDescricao.Text;
        servico.Status = ckdStatus.Checked;
        servico.Tipo = txtTipo.Text;
        
        servico.Setor = setor;
      


        ServicoBD bd = new ServicoBD();
        if (bd.Insert(servico))
        {
            lblMensagem.Text = "Servico cadastrado com sucesso";
            txtDescricao.Text = "";
            txtTipo.Text = "";

            //remove seleção do ddl
            for (int i = 0; i < ddlSetor.Items.Count; i++)
            {
                ddlSetor.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlSetor.Items[0].Selected = true;

            txtTipo.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}