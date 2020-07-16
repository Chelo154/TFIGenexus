/*
               File: Cliente
        Description: Cliente
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:2:51.50
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class cliente : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A13id_Localidad = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A13id_Localidad) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_8-139369", 0) ;
            Form.Meta.addItem("description", "Cliente", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtidCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public cliente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public cliente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Cliente", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         ClassString = "ErrorViewer";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "BtnFirst";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDCLIENTE"+"'), id:'"+"IDCLIENTE"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidCliente_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidCliente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1idCliente), 4, 0, ".", "")), ((edtidCliente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1idCliente), "ZZZ9")) : context.localUtil.Format( (decimal)(A1idCliente), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidCliente_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdniCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtdniCliente_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtdniCliente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7dniCliente), 10, 0, ".", "")), ((edtdniCliente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7dniCliente), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A7dniCliente), "ZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdniCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdniCliente_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtapellidoCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtapellidoCliente_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtapellidoCliente_Internalname, A8apellidoCliente, StringUtil.RTrim( context.localUtil.Format( A8apellidoCliente, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtapellidoCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtapellidoCliente_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtnombreCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtnombreCliente_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtnombreCliente_Internalname, A9nombreCliente, StringUtil.RTrim( context.localUtil.Format( A9nombreCliente, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreCliente_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdireccionCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtdireccionCliente_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtdireccionCliente_Internalname, A10direccionCliente, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A10direccionCliente), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", 0, 1, edtdireccionCliente_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttelefonoCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttelefonoCliente_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         if ( context.isSmartDevice( ) )
         {
            gxphoneLink = "tel:" + StringUtil.RTrim( A11telefonoCliente);
         }
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edttelefonoCliente_Internalname, StringUtil.RTrim( A11telefonoCliente), StringUtil.RTrim( context.localUtil.Format( A11telefonoCliente, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", gxphoneLink, "", "", "", edttelefonoCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttelefonoCliente_Enabled, 0, "tel", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Phone", "left", true, "", "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtid_Localidad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtid_Localidad_Internalname, "id_Localidad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtid_Localidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13id_Localidad), 4, 0, ".", "")), ((edtid_Localidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13id_Localidad), "ZZZ9")) : context.localUtil.Format( (decimal)(A13id_Localidad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtid_Localidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtid_Localidad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Cliente.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_13_Internalname, sImgUrl, imgprompt_13_Link, "", "", context.GetTheme( ), imgprompt_13_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtnombreLocalidad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtnombreLocalidad_Internalname, "nombre Localidad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtnombreLocalidad_Internalname, A50nombreLocalidad, StringUtil.RTrim( context.localUtil.Format( A50nombreLocalidad, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreLocalidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreLocalidad_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Z1idCliente = (short)(context.localUtil.CToN( cgiGet( "Z1idCliente"), ".", ","));
            Z7dniCliente = (long)(context.localUtil.CToN( cgiGet( "Z7dniCliente"), ".", ","));
            Z8apellidoCliente = cgiGet( "Z8apellidoCliente");
            Z9nombreCliente = cgiGet( "Z9nombreCliente");
            Z10direccionCliente = cgiGet( "Z10direccionCliente");
            Z11telefonoCliente = cgiGet( "Z11telefonoCliente");
            Z13id_Localidad = (short)(context.localUtil.CToN( cgiGet( "Z13id_Localidad"), ".", ","));
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtidCliente_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidCliente_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDCLIENTE");
               AnyError = 1;
               GX_FocusControl = edtidCliente_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A1idCliente = 0;
               AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            }
            else
            {
               A1idCliente = (short)(context.localUtil.CToN( cgiGet( edtidCliente_Internalname), ".", ","));
               AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtdniCliente_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdniCliente_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DNICLIENTE");
               AnyError = 1;
               GX_FocusControl = edtdniCliente_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A7dniCliente = 0;
               AssignAttri("", false, "A7dniCliente", StringUtil.LTrimStr( (decimal)(A7dniCliente), 10, 0));
            }
            else
            {
               A7dniCliente = (long)(context.localUtil.CToN( cgiGet( edtdniCliente_Internalname), ".", ","));
               AssignAttri("", false, "A7dniCliente", StringUtil.LTrimStr( (decimal)(A7dniCliente), 10, 0));
            }
            A8apellidoCliente = cgiGet( edtapellidoCliente_Internalname);
            AssignAttri("", false, "A8apellidoCliente", A8apellidoCliente);
            A9nombreCliente = cgiGet( edtnombreCliente_Internalname);
            AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
            A10direccionCliente = cgiGet( edtdireccionCliente_Internalname);
            AssignAttri("", false, "A10direccionCliente", A10direccionCliente);
            A11telefonoCliente = cgiGet( edttelefonoCliente_Internalname);
            AssignAttri("", false, "A11telefonoCliente", A11telefonoCliente);
            if ( ( ( context.localUtil.CToN( cgiGet( edtid_Localidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtid_Localidad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ID_LOCALIDAD");
               AnyError = 1;
               GX_FocusControl = edtid_Localidad_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A13id_Localidad = 0;
               AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            }
            else
            {
               A13id_Localidad = (short)(context.localUtil.CToN( cgiGet( edtid_Localidad_Internalname), ".", ","));
               AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            }
            A50nombreLocalidad = cgiGet( edtnombreLocalidad_Internalname);
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            standaloneNotModal( ) ;
         }
         else
         {
            standaloneNotModal( ) ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
            {
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               A1idCliente = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
               getEqualNoModal( ) ;
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               disable_std_buttons_dsp( ) ;
               standaloneModal( ) ;
            }
            else
            {
               Gx_mode = "INS";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               standaloneModal( ) ;
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( IsIns( ) )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         if ( IsDsp( ) )
         {
            bttBtn_enter_Visible = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
         }
         DisableAttributes011( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void ResetCaption010( )
      {
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z7dniCliente = T00013_A7dniCliente[0];
               Z8apellidoCliente = T00013_A8apellidoCliente[0];
               Z9nombreCliente = T00013_A9nombreCliente[0];
               Z10direccionCliente = T00013_A10direccionCliente[0];
               Z11telefonoCliente = T00013_A11telefonoCliente[0];
               Z13id_Localidad = T00013_A13id_Localidad[0];
            }
            else
            {
               Z7dniCliente = A7dniCliente;
               Z8apellidoCliente = A8apellidoCliente;
               Z9nombreCliente = A9nombreCliente;
               Z10direccionCliente = A10direccionCliente;
               Z11telefonoCliente = A11telefonoCliente;
               Z13id_Localidad = A13id_Localidad;
            }
         }
         if ( GX_JID == -1 )
         {
            Z1idCliente = A1idCliente;
            Z7dniCliente = A7dniCliente;
            Z8apellidoCliente = A8apellidoCliente;
            Z9nombreCliente = A9nombreCliente;
            Z10direccionCliente = A10direccionCliente;
            Z11telefonoCliente = A11telefonoCliente;
            Z13id_Localidad = A13id_Localidad;
            Z50nombreLocalidad = A50nombreLocalidad;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_13_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ID_LOCALIDAD"+"'), id:'"+"ID_LOCALIDAD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A7dniCliente = T00015_A7dniCliente[0];
            AssignAttri("", false, "A7dniCliente", StringUtil.LTrimStr( (decimal)(A7dniCliente), 10, 0));
            A8apellidoCliente = T00015_A8apellidoCliente[0];
            AssignAttri("", false, "A8apellidoCliente", A8apellidoCliente);
            A9nombreCliente = T00015_A9nombreCliente[0];
            AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
            A10direccionCliente = T00015_A10direccionCliente[0];
            AssignAttri("", false, "A10direccionCliente", A10direccionCliente);
            A11telefonoCliente = T00015_A11telefonoCliente[0];
            AssignAttri("", false, "A11telefonoCliente", A11telefonoCliente);
            A50nombreLocalidad = T00015_A50nombreLocalidad[0];
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            A13id_Localidad = T00015_A13id_Localidad[0];
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            ZM011( -1) ;
         }
         pr_default.close(3);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         nIsDirty_1 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50nombreLocalidad = T00014_A50nombreLocalidad[0];
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A13id_Localidad )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50nombreLocalidad = T00016_A50nombreLocalidad[0];
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A50nombreLocalidad)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(4) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(4);
      }

      protected void GetKey011( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 1) ;
            RcdFound1 = 1;
            A1idCliente = T00013_A1idCliente[0];
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            A7dniCliente = T00013_A7dniCliente[0];
            AssignAttri("", false, "A7dniCliente", StringUtil.LTrimStr( (decimal)(A7dniCliente), 10, 0));
            A8apellidoCliente = T00013_A8apellidoCliente[0];
            AssignAttri("", false, "A8apellidoCliente", A8apellidoCliente);
            A9nombreCliente = T00013_A9nombreCliente[0];
            AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
            A10direccionCliente = T00013_A10direccionCliente[0];
            AssignAttri("", false, "A10direccionCliente", A10direccionCliente);
            A11telefonoCliente = T00013_A11telefonoCliente[0];
            AssignAttri("", false, "A11telefonoCliente", A11telefonoCliente);
            A13id_Localidad = T00013_A13id_Localidad[0];
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            Z1idCliente = A1idCliente;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00018_A1idCliente[0] < A1idCliente ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00018_A1idCliente[0] > A1idCliente ) ) )
            {
               A1idCliente = T00018_A1idCliente[0];
               AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
               RcdFound1 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1idCliente[0] > A1idCliente ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1idCliente[0] < A1idCliente ) ) )
            {
               A1idCliente = T00019_A1idCliente[0];
               AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtidCliente_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1idCliente != Z1idCliente )
               {
                  A1idCliente = Z1idCliente;
                  AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDCLIENTE");
                  AnyError = 1;
                  GX_FocusControl = edtidCliente_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtidCliente_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtidCliente_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1idCliente != Z1idCliente )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtidCliente_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDCLIENTE");
                     AnyError = 1;
                     GX_FocusControl = edtidCliente_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtidCliente_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A1idCliente != Z1idCliente )
         {
            A1idCliente = Z1idCliente;
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDCLIENTE");
            AnyError = 1;
            GX_FocusControl = edtidCliente_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtidCliente_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "IDCLIENTE");
            AnyError = 1;
            GX_FocusControl = edtidCliente_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtdniCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_previous( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_next( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound1 != 0 )
            {
               ScanNext011( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1idCliente});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z7dniCliente != T00012_A7dniCliente[0] ) || ( StringUtil.StrCmp(Z8apellidoCliente, T00012_A8apellidoCliente[0]) != 0 ) || ( StringUtil.StrCmp(Z9nombreCliente, T00012_A9nombreCliente[0]) != 0 ) || ( StringUtil.StrCmp(Z10direccionCliente, T00012_A10direccionCliente[0]) != 0 ) || ( StringUtil.StrCmp(Z11telefonoCliente, T00012_A11telefonoCliente[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z13id_Localidad != T00012_A13id_Localidad[0] ) )
            {
               if ( Z7dniCliente != T00012_A7dniCliente[0] )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"dniCliente");
                  GXUtil.WriteLogRaw("Old: ",Z7dniCliente);
                  GXUtil.WriteLogRaw("Current: ",T00012_A7dniCliente[0]);
               }
               if ( StringUtil.StrCmp(Z8apellidoCliente, T00012_A8apellidoCliente[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"apellidoCliente");
                  GXUtil.WriteLogRaw("Old: ",Z8apellidoCliente);
                  GXUtil.WriteLogRaw("Current: ",T00012_A8apellidoCliente[0]);
               }
               if ( StringUtil.StrCmp(Z9nombreCliente, T00012_A9nombreCliente[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"nombreCliente");
                  GXUtil.WriteLogRaw("Old: ",Z9nombreCliente);
                  GXUtil.WriteLogRaw("Current: ",T00012_A9nombreCliente[0]);
               }
               if ( StringUtil.StrCmp(Z10direccionCliente, T00012_A10direccionCliente[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"direccionCliente");
                  GXUtil.WriteLogRaw("Old: ",Z10direccionCliente);
                  GXUtil.WriteLogRaw("Current: ",T00012_A10direccionCliente[0]);
               }
               if ( StringUtil.StrCmp(Z11telefonoCliente, T00012_A11telefonoCliente[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"telefonoCliente");
                  GXUtil.WriteLogRaw("Old: ",Z11telefonoCliente);
                  GXUtil.WriteLogRaw("Current: ",T00012_A11telefonoCliente[0]);
               }
               if ( Z13id_Localidad != T00012_A13id_Localidad[0] )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"id_Localidad");
                  GXUtil.WriteLogRaw("Old: ",Z13id_Localidad);
                  GXUtil.WriteLogRaw("Current: ",T00012_A13id_Localidad[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Cliente"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000110 */
                     pr_default.execute(8, new Object[] {A7dniCliente, A8apellidoCliente, A9nombreCliente, A10direccionCliente, A11telefonoCliente, A13id_Localidad});
                     A1idCliente = T000110_A1idCliente[0];
                     AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption010( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A7dniCliente, A8apellidoCliente, A9nombreCliente, A10direccionCliente, A11telefonoCliente, A13id_Localidad, A1idCliente});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption010( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000112 */
                  pr_default.execute(10, new Object[] {A1idCliente});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound1 == 0 )
                        {
                           InitAll011( ) ;
                           Gx_mode = "INS";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption010( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel011( ) ;
         Gx_mode = sMode1;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000113 */
            pr_default.execute(11, new Object[] {A13id_Localidad});
            A50nombreLocalidad = T000113_A50nombreLocalidad[0];
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000114 */
            pr_default.execute(12, new Object[] {A1idCliente});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Venta"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel011( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("cliente",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("cliente",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Using cursor T000115 */
         pr_default.execute(13);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1idCliente = T000115_A1idCliente[0];
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1idCliente = T000115_A1idCliente[0];
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtidCliente_Enabled = 0;
         AssignProp("", false, edtidCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidCliente_Enabled), 5, 0), true);
         edtdniCliente_Enabled = 0;
         AssignProp("", false, edtdniCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdniCliente_Enabled), 5, 0), true);
         edtapellidoCliente_Enabled = 0;
         AssignProp("", false, edtapellidoCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtapellidoCliente_Enabled), 5, 0), true);
         edtnombreCliente_Enabled = 0;
         AssignProp("", false, edtnombreCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreCliente_Enabled), 5, 0), true);
         edtdireccionCliente_Enabled = 0;
         AssignProp("", false, edtdireccionCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdireccionCliente_Enabled), 5, 0), true);
         edttelefonoCliente_Enabled = 0;
         AssignProp("", false, edttelefonoCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttelefonoCliente_Enabled), 5, 0), true);
         edtid_Localidad_Enabled = 0;
         AssignProp("", false, edtid_Localidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtid_Localidad_Enabled), 5, 0), true);
         edtnombreLocalidad_Enabled = 0;
         AssignProp("", false, edtnombreLocalidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreLocalidad_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 139369), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 139369), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 139369), false, true);
         context.AddJavascriptSource("gxcfg.js", "?2020716132529", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("cliente.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1idCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1idCliente), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z7dniCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7dniCliente), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z8apellidoCliente", Z8apellidoCliente);
         GxWebStd.gx_hidden_field( context, "Z9nombreCliente", Z9nombreCliente);
         GxWebStd.gx_hidden_field( context, "Z10direccionCliente", Z10direccionCliente);
         GxWebStd.gx_hidden_field( context, "Z11telefonoCliente", StringUtil.RTrim( Z11telefonoCliente));
         GxWebStd.gx_hidden_field( context, "Z13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13id_Localidad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cliente.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Cliente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cliente" ;
      }

      protected void InitializeNonKey011( )
      {
         A7dniCliente = 0;
         AssignAttri("", false, "A7dniCliente", StringUtil.LTrimStr( (decimal)(A7dniCliente), 10, 0));
         A8apellidoCliente = "";
         AssignAttri("", false, "A8apellidoCliente", A8apellidoCliente);
         A9nombreCliente = "";
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
         A10direccionCliente = "";
         AssignAttri("", false, "A10direccionCliente", A10direccionCliente);
         A11telefonoCliente = "";
         AssignAttri("", false, "A11telefonoCliente", A11telefonoCliente);
         A13id_Localidad = 0;
         AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
         A50nombreLocalidad = "";
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         Z7dniCliente = 0;
         Z8apellidoCliente = "";
         Z9nombreCliente = "";
         Z10direccionCliente = "";
         Z11telefonoCliente = "";
         Z13id_Localidad = 0;
      }

      protected void InitAll011( )
      {
         A1idCliente = 0;
         AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20207161325213", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("cliente.js", "?20207161325213", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtidCliente_Internalname = "IDCLIENTE";
         edtdniCliente_Internalname = "DNICLIENTE";
         edtapellidoCliente_Internalname = "APELLIDOCLIENTE";
         edtnombreCliente_Internalname = "NOMBRECLIENTE";
         edtdireccionCliente_Internalname = "DIRECCIONCLIENTE";
         edttelefonoCliente_Internalname = "TELEFONOCLIENTE";
         edtid_Localidad_Internalname = "ID_LOCALIDAD";
         edtnombreLocalidad_Internalname = "NOMBRELOCALIDAD";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_13_Internalname = "PROMPT_13";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Cliente";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtnombreLocalidad_Jsonclick = "";
         edtnombreLocalidad_Enabled = 0;
         imgprompt_13_Visible = 1;
         imgprompt_13_Link = "";
         edtid_Localidad_Jsonclick = "";
         edtid_Localidad_Enabled = 1;
         edttelefonoCliente_Jsonclick = "";
         edttelefonoCliente_Enabled = 1;
         edtdireccionCliente_Enabled = 1;
         edtnombreCliente_Jsonclick = "";
         edtnombreCliente_Enabled = 1;
         edtapellidoCliente_Jsonclick = "";
         edtapellidoCliente_Enabled = 1;
         edtdniCliente_Jsonclick = "";
         edtdniCliente_Enabled = 1;
         edtidCliente_Jsonclick = "";
         edtidCliente_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtdniCliente_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void Valid_Idcliente( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A7dniCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7dniCliente), 10, 0, ".", "")));
         AssignAttri("", false, "A8apellidoCliente", A8apellidoCliente);
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
         AssignAttri("", false, "A10direccionCliente", A10direccionCliente);
         AssignAttri("", false, "A11telefonoCliente", StringUtil.RTrim( A11telefonoCliente));
         AssignAttri("", false, "A13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13id_Localidad), 4, 0, ".", "")));
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z1idCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1idCliente), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z7dniCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7dniCliente), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z8apellidoCliente", Z8apellidoCliente);
         GxWebStd.gx_hidden_field( context, "Z9nombreCliente", Z9nombreCliente);
         GxWebStd.gx_hidden_field( context, "Z10direccionCliente", Z10direccionCliente);
         GxWebStd.gx_hidden_field( context, "Z11telefonoCliente", StringUtil.RTrim( Z11telefonoCliente));
         GxWebStd.gx_hidden_field( context, "Z13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13id_Localidad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z50nombreLocalidad", Z50nombreLocalidad);
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Id_localidad( )
      {
         /* Using cursor T000113 */
         pr_default.execute(11, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
         }
         A50nombreLocalidad = T000113_A50nombreLocalidad[0];
         pr_default.close(11);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("VALID_IDCLIENTE","{handler:'Valid_Idcliente',iparms:[{av:'A1idCliente',fld:'IDCLIENTE',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_IDCLIENTE",",oparms:[{av:'A7dniCliente',fld:'DNICLIENTE',pic:'ZZZZZZZZZ9'},{av:'A8apellidoCliente',fld:'APELLIDOCLIENTE',pic:''},{av:'A9nombreCliente',fld:'NOMBRECLIENTE',pic:''},{av:'A10direccionCliente',fld:'DIRECCIONCLIENTE',pic:''},{av:'A11telefonoCliente',fld:'TELEFONOCLIENTE',pic:''},{av:'A13id_Localidad',fld:'ID_LOCALIDAD',pic:'ZZZ9'},{av:'A50nombreLocalidad',fld:'NOMBRELOCALIDAD',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z1idCliente'},{av:'Z7dniCliente'},{av:'Z8apellidoCliente'},{av:'Z9nombreCliente'},{av:'Z10direccionCliente'},{av:'Z11telefonoCliente'},{av:'Z13id_Localidad'},{av:'Z50nombreLocalidad'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_ID_LOCALIDAD","{handler:'Valid_Id_localidad',iparms:[{av:'A13id_Localidad',fld:'ID_LOCALIDAD',pic:'ZZZ9'},{av:'A50nombreLocalidad',fld:'NOMBRELOCALIDAD',pic:''}]");
         setEventMetadata("VALID_ID_LOCALIDAD",",oparms:[{av:'A50nombreLocalidad',fld:'NOMBRELOCALIDAD',pic:''}]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z8apellidoCliente = "";
         Z9nombreCliente = "";
         Z10direccionCliente = "";
         Z11telefonoCliente = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A8apellidoCliente = "";
         A9nombreCliente = "";
         A10direccionCliente = "";
         gxphoneLink = "";
         A11telefonoCliente = "";
         sImgUrl = "";
         A50nombreLocalidad = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z50nombreLocalidad = "";
         T00015_A1idCliente = new short[1] ;
         T00015_A7dniCliente = new long[1] ;
         T00015_A8apellidoCliente = new String[] {""} ;
         T00015_A9nombreCliente = new String[] {""} ;
         T00015_A10direccionCliente = new String[] {""} ;
         T00015_A11telefonoCliente = new String[] {""} ;
         T00015_A50nombreLocalidad = new String[] {""} ;
         T00015_A13id_Localidad = new short[1] ;
         T00014_A50nombreLocalidad = new String[] {""} ;
         T00016_A50nombreLocalidad = new String[] {""} ;
         T00017_A1idCliente = new short[1] ;
         T00013_A1idCliente = new short[1] ;
         T00013_A7dniCliente = new long[1] ;
         T00013_A8apellidoCliente = new String[] {""} ;
         T00013_A9nombreCliente = new String[] {""} ;
         T00013_A10direccionCliente = new String[] {""} ;
         T00013_A11telefonoCliente = new String[] {""} ;
         T00013_A13id_Localidad = new short[1] ;
         sMode1 = "";
         T00018_A1idCliente = new short[1] ;
         T00019_A1idCliente = new short[1] ;
         T00012_A1idCliente = new short[1] ;
         T00012_A7dniCliente = new long[1] ;
         T00012_A8apellidoCliente = new String[] {""} ;
         T00012_A9nombreCliente = new String[] {""} ;
         T00012_A10direccionCliente = new String[] {""} ;
         T00012_A11telefonoCliente = new String[] {""} ;
         T00012_A13id_Localidad = new short[1] ;
         T000110_A1idCliente = new short[1] ;
         T000113_A50nombreLocalidad = new String[] {""} ;
         T000114_A5idVenta = new short[1] ;
         T000115_A1idCliente = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ8apellidoCliente = "";
         ZZ9nombreCliente = "";
         ZZ10direccionCliente = "";
         ZZ11telefonoCliente = "";
         ZZ50nombreLocalidad = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cliente__default(),
            new Object[][] {
                new Object[] {
               T00012_A1idCliente, T00012_A7dniCliente, T00012_A8apellidoCliente, T00012_A9nombreCliente, T00012_A10direccionCliente, T00012_A11telefonoCliente, T00012_A13id_Localidad
               }
               , new Object[] {
               T00013_A1idCliente, T00013_A7dniCliente, T00013_A8apellidoCliente, T00013_A9nombreCliente, T00013_A10direccionCliente, T00013_A11telefonoCliente, T00013_A13id_Localidad
               }
               , new Object[] {
               T00014_A50nombreLocalidad
               }
               , new Object[] {
               T00015_A1idCliente, T00015_A7dniCliente, T00015_A8apellidoCliente, T00015_A9nombreCliente, T00015_A10direccionCliente, T00015_A11telefonoCliente, T00015_A50nombreLocalidad, T00015_A13id_Localidad
               }
               , new Object[] {
               T00016_A50nombreLocalidad
               }
               , new Object[] {
               T00017_A1idCliente
               }
               , new Object[] {
               T00018_A1idCliente
               }
               , new Object[] {
               T00019_A1idCliente
               }
               , new Object[] {
               T000110_A1idCliente
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000113_A50nombreLocalidad
               }
               , new Object[] {
               T000114_A5idVenta
               }
               , new Object[] {
               T000115_A1idCliente
               }
            }
         );
      }

      private short Z1idCliente ;
      private short Z13id_Localidad ;
      private short GxWebError ;
      private short A13id_Localidad ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A1idCliente ;
      private short GX_JID ;
      private short RcdFound1 ;
      private short nIsDirty_1 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ1idCliente ;
      private short ZZ13id_Localidad ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtidCliente_Enabled ;
      private int edtdniCliente_Enabled ;
      private int edtapellidoCliente_Enabled ;
      private int edtnombreCliente_Enabled ;
      private int edtdireccionCliente_Enabled ;
      private int edttelefonoCliente_Enabled ;
      private int edtid_Localidad_Enabled ;
      private int imgprompt_13_Visible ;
      private int edtnombreLocalidad_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z7dniCliente ;
      private long A7dniCliente ;
      private long ZZ7dniCliente ;
      private String sPrefix ;
      private String Z11telefonoCliente ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtidCliente_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtidCliente_Jsonclick ;
      private String edtdniCliente_Internalname ;
      private String edtdniCliente_Jsonclick ;
      private String edtapellidoCliente_Internalname ;
      private String edtapellidoCliente_Jsonclick ;
      private String edtnombreCliente_Internalname ;
      private String edtnombreCliente_Jsonclick ;
      private String edtdireccionCliente_Internalname ;
      private String edttelefonoCliente_Internalname ;
      private String gxphoneLink ;
      private String A11telefonoCliente ;
      private String edttelefonoCliente_Jsonclick ;
      private String edtid_Localidad_Internalname ;
      private String edtid_Localidad_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_13_Internalname ;
      private String imgprompt_13_Link ;
      private String edtnombreLocalidad_Internalname ;
      private String edtnombreLocalidad_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String ZZ11telefonoCliente ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String Z8apellidoCliente ;
      private String Z9nombreCliente ;
      private String Z10direccionCliente ;
      private String A8apellidoCliente ;
      private String A9nombreCliente ;
      private String A10direccionCliente ;
      private String A50nombreLocalidad ;
      private String Z50nombreLocalidad ;
      private String ZZ8apellidoCliente ;
      private String ZZ9nombreCliente ;
      private String ZZ10direccionCliente ;
      private String ZZ50nombreLocalidad ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00015_A1idCliente ;
      private long[] T00015_A7dniCliente ;
      private String[] T00015_A8apellidoCliente ;
      private String[] T00015_A9nombreCliente ;
      private String[] T00015_A10direccionCliente ;
      private String[] T00015_A11telefonoCliente ;
      private String[] T00015_A50nombreLocalidad ;
      private short[] T00015_A13id_Localidad ;
      private String[] T00014_A50nombreLocalidad ;
      private String[] T00016_A50nombreLocalidad ;
      private short[] T00017_A1idCliente ;
      private short[] T00013_A1idCliente ;
      private long[] T00013_A7dniCliente ;
      private String[] T00013_A8apellidoCliente ;
      private String[] T00013_A9nombreCliente ;
      private String[] T00013_A10direccionCliente ;
      private String[] T00013_A11telefonoCliente ;
      private short[] T00013_A13id_Localidad ;
      private short[] T00018_A1idCliente ;
      private short[] T00019_A1idCliente ;
      private short[] T00012_A1idCliente ;
      private long[] T00012_A7dniCliente ;
      private String[] T00012_A8apellidoCliente ;
      private String[] T00012_A9nombreCliente ;
      private String[] T00012_A10direccionCliente ;
      private String[] T00012_A11telefonoCliente ;
      private short[] T00012_A13id_Localidad ;
      private short[] T000110_A1idCliente ;
      private String[] T000113_A50nombreLocalidad ;
      private short[] T000114_A5idVenta ;
      private short[] T000115_A1idCliente ;
      private GXWebForm Form ;
   }

   public class cliente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@dniCliente",SqlDbType.Decimal,10,0} ,
          new Object[] {"@apellidoCliente",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@nombreCliente",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@direccionCliente",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@telefonoCliente",SqlDbType.NChar,20,0} ,
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@dniCliente",SqlDbType.Decimal,10,0} ,
          new Object[] {"@apellidoCliente",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@nombreCliente",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@direccionCliente",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@telefonoCliente",SqlDbType.NChar,20,0} ,
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [idCliente], [dniCliente], [apellidoCliente], [nombreCliente], [direccionCliente], [telefonoCliente], [id_Localidad] FROM [Cliente] WITH (UPDLOCK) WHERE [idCliente] = @idCliente ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00013", "SELECT [idCliente], [dniCliente], [apellidoCliente], [nombreCliente], [direccionCliente], [telefonoCliente], [id_Localidad] FROM [Cliente] WHERE [idCliente] = @idCliente ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00014", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00015", "SELECT TM1.[idCliente], TM1.[dniCliente], TM1.[apellidoCliente], TM1.[nombreCliente], TM1.[direccionCliente], TM1.[telefonoCliente], T2.[nombreLocalidad], TM1.[id_Localidad] FROM ([Cliente] TM1 INNER JOIN [Localidad] T2 ON T2.[id_Localidad] = TM1.[id_Localidad]) WHERE TM1.[idCliente] = @idCliente ORDER BY TM1.[idCliente]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00016", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00017", "SELECT [idCliente] FROM [Cliente] WHERE [idCliente] = @idCliente  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00018", "SELECT TOP 1 [idCliente] FROM [Cliente] WHERE ( [idCliente] > @idCliente) ORDER BY [idCliente]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00019", "SELECT TOP 1 [idCliente] FROM [Cliente] WHERE ( [idCliente] < @idCliente) ORDER BY [idCliente] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000110", "INSERT INTO [Cliente]([dniCliente], [apellidoCliente], [nombreCliente], [direccionCliente], [telefonoCliente], [id_Localidad]) VALUES(@dniCliente, @apellidoCliente, @nombreCliente, @direccionCliente, @telefonoCliente, @id_Localidad); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000110)
             ,new CursorDef("T000111", "UPDATE [Cliente] SET [dniCliente]=@dniCliente, [apellidoCliente]=@apellidoCliente, [nombreCliente]=@nombreCliente, [direccionCliente]=@direccionCliente, [telefonoCliente]=@telefonoCliente, [id_Localidad]=@id_Localidad  WHERE [idCliente] = @idCliente", GxErrorMask.GX_NOMASK,prmT000111)
             ,new CursorDef("T000112", "DELETE FROM [Cliente]  WHERE [idCliente] = @idCliente", GxErrorMask.GX_NOMASK,prmT000112)
             ,new CursorDef("T000113", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000114", "SELECT TOP 1 [idVenta] FROM [Venta] WHERE [idCliente] = @idCliente ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000115", "SELECT [idCliente] FROM [Cliente] ORDER BY [idCliente]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,100, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
