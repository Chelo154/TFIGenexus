/*
               File: Empleado
        Description: Empleado
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:3:1.78
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
   public class empleado : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "Empleado", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtidEmpleado_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public empleado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public empleado( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Empleado", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Empleado.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDEMPLEADO"+"'), id:'"+"IDEMPLEADO"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Empleado.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidEmpleado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidEmpleado_Internalname, "Empleado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidEmpleado_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4idEmpleado), 4, 0, ".", "")), ((edtidEmpleado_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A4idEmpleado), "ZZZ9")) : context.localUtil.Format( (decimal)(A4idEmpleado), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidEmpleado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidEmpleado_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdniEmpleado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtdniEmpleado_Internalname, "Empleado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtdniEmpleado_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24dniEmpleado), 4, 0, ".", "")), ((edtdniEmpleado_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A24dniEmpleado), "ZZZ9")) : context.localUtil.Format( (decimal)(A24dniEmpleado), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdniEmpleado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdniEmpleado_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtapellidoEmpleado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtapellidoEmpleado_Internalname, "Empleado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtapellidoEmpleado_Internalname, A25apellidoEmpleado, StringUtil.RTrim( context.localUtil.Format( A25apellidoEmpleado, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtapellidoEmpleado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtapellidoEmpleado_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtnombreEmpleado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtnombreEmpleado_Internalname, "Empleado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtnombreEmpleado_Internalname, A26nombreEmpleado, StringUtil.RTrim( context.localUtil.Format( A26nombreEmpleado, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreEmpleado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreEmpleado_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttelefonoEmpleado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttelefonoEmpleado_Internalname, "Empleado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         if ( context.isSmartDevice( ) )
         {
            gxphoneLink = "tel:" + StringUtil.RTrim( A27telefonoEmpleado);
         }
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edttelefonoEmpleado_Internalname, StringUtil.RTrim( A27telefonoEmpleado), StringUtil.RTrim( context.localUtil.Format( A27telefonoEmpleado, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", gxphoneLink, "", "", "", edttelefonoEmpleado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttelefonoEmpleado_Enabled, 0, "tel", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Phone", "left", true, "", "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdireccionEmpleado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtdireccionEmpleado_Internalname, "Empleado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtdireccionEmpleado_Internalname, A28direccionEmpleado, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A28direccionEmpleado), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,59);\"", 0, 1, edtdireccionEmpleado_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Empleado.htm");
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
         GxWebStd.gx_single_line_edit( context, edtid_Localidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13id_Localidad), 4, 0, ".", "")), ((edtid_Localidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13id_Localidad), "ZZZ9")) : context.localUtil.Format( (decimal)(A13id_Localidad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtid_Localidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtid_Localidad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Empleado.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_13_Internalname, sImgUrl, imgprompt_13_Link, "", "", context.GetTheme( ), imgprompt_13_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Empleado.htm");
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
         GxWebStd.gx_single_line_edit( context, edtnombreLocalidad_Internalname, A50nombreLocalidad, StringUtil.RTrim( context.localUtil.Format( A50nombreLocalidad, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreLocalidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreLocalidad_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Empleado.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Empleado.htm");
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
            Z4idEmpleado = (short)(context.localUtil.CToN( cgiGet( "Z4idEmpleado"), ".", ","));
            Z24dniEmpleado = (short)(context.localUtil.CToN( cgiGet( "Z24dniEmpleado"), ".", ","));
            Z25apellidoEmpleado = cgiGet( "Z25apellidoEmpleado");
            Z26nombreEmpleado = cgiGet( "Z26nombreEmpleado");
            Z27telefonoEmpleado = cgiGet( "Z27telefonoEmpleado");
            Z28direccionEmpleado = cgiGet( "Z28direccionEmpleado");
            Z13id_Localidad = (short)(context.localUtil.CToN( cgiGet( "Z13id_Localidad"), ".", ","));
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtidEmpleado_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidEmpleado_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDEMPLEADO");
               AnyError = 1;
               GX_FocusControl = edtidEmpleado_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A4idEmpleado = 0;
               AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
            }
            else
            {
               A4idEmpleado = (short)(context.localUtil.CToN( cgiGet( edtidEmpleado_Internalname), ".", ","));
               AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtdniEmpleado_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdniEmpleado_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DNIEMPLEADO");
               AnyError = 1;
               GX_FocusControl = edtdniEmpleado_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A24dniEmpleado = 0;
               AssignAttri("", false, "A24dniEmpleado", StringUtil.LTrimStr( (decimal)(A24dniEmpleado), 4, 0));
            }
            else
            {
               A24dniEmpleado = (short)(context.localUtil.CToN( cgiGet( edtdniEmpleado_Internalname), ".", ","));
               AssignAttri("", false, "A24dniEmpleado", StringUtil.LTrimStr( (decimal)(A24dniEmpleado), 4, 0));
            }
            A25apellidoEmpleado = cgiGet( edtapellidoEmpleado_Internalname);
            AssignAttri("", false, "A25apellidoEmpleado", A25apellidoEmpleado);
            A26nombreEmpleado = cgiGet( edtnombreEmpleado_Internalname);
            AssignAttri("", false, "A26nombreEmpleado", A26nombreEmpleado);
            A27telefonoEmpleado = cgiGet( edttelefonoEmpleado_Internalname);
            AssignAttri("", false, "A27telefonoEmpleado", A27telefonoEmpleado);
            A28direccionEmpleado = cgiGet( edtdireccionEmpleado_Internalname);
            AssignAttri("", false, "A28direccionEmpleado", A28direccionEmpleado);
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
               A4idEmpleado = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
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
               InitAll044( ) ;
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
         DisableAttributes044( ) ;
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

      protected void ResetCaption040( )
      {
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z24dniEmpleado = T00043_A24dniEmpleado[0];
               Z25apellidoEmpleado = T00043_A25apellidoEmpleado[0];
               Z26nombreEmpleado = T00043_A26nombreEmpleado[0];
               Z27telefonoEmpleado = T00043_A27telefonoEmpleado[0];
               Z28direccionEmpleado = T00043_A28direccionEmpleado[0];
               Z13id_Localidad = T00043_A13id_Localidad[0];
            }
            else
            {
               Z24dniEmpleado = A24dniEmpleado;
               Z25apellidoEmpleado = A25apellidoEmpleado;
               Z26nombreEmpleado = A26nombreEmpleado;
               Z27telefonoEmpleado = A27telefonoEmpleado;
               Z28direccionEmpleado = A28direccionEmpleado;
               Z13id_Localidad = A13id_Localidad;
            }
         }
         if ( GX_JID == -1 )
         {
            Z4idEmpleado = A4idEmpleado;
            Z24dniEmpleado = A24dniEmpleado;
            Z25apellidoEmpleado = A25apellidoEmpleado;
            Z26nombreEmpleado = A26nombreEmpleado;
            Z27telefonoEmpleado = A27telefonoEmpleado;
            Z28direccionEmpleado = A28direccionEmpleado;
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

      protected void Load044( )
      {
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {A4idEmpleado});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1;
            A24dniEmpleado = T00045_A24dniEmpleado[0];
            AssignAttri("", false, "A24dniEmpleado", StringUtil.LTrimStr( (decimal)(A24dniEmpleado), 4, 0));
            A25apellidoEmpleado = T00045_A25apellidoEmpleado[0];
            AssignAttri("", false, "A25apellidoEmpleado", A25apellidoEmpleado);
            A26nombreEmpleado = T00045_A26nombreEmpleado[0];
            AssignAttri("", false, "A26nombreEmpleado", A26nombreEmpleado);
            A27telefonoEmpleado = T00045_A27telefonoEmpleado[0];
            AssignAttri("", false, "A27telefonoEmpleado", A27telefonoEmpleado);
            A28direccionEmpleado = T00045_A28direccionEmpleado[0];
            AssignAttri("", false, "A28direccionEmpleado", A28direccionEmpleado);
            A50nombreLocalidad = T00045_A50nombreLocalidad[0];
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            A13id_Localidad = T00045_A13id_Localidad[0];
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            ZM044( -1) ;
         }
         pr_default.close(3);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
      }

      protected void CheckExtendedTable044( )
      {
         nIsDirty_4 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50nombreLocalidad = T00044_A50nombreLocalidad[0];
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors044( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A13id_Localidad )
      {
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50nombreLocalidad = T00046_A50nombreLocalidad[0];
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

      protected void GetKey044( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A4idEmpleado});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A4idEmpleado});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM044( 1) ;
            RcdFound4 = 1;
            A4idEmpleado = T00043_A4idEmpleado[0];
            AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
            A24dniEmpleado = T00043_A24dniEmpleado[0];
            AssignAttri("", false, "A24dniEmpleado", StringUtil.LTrimStr( (decimal)(A24dniEmpleado), 4, 0));
            A25apellidoEmpleado = T00043_A25apellidoEmpleado[0];
            AssignAttri("", false, "A25apellidoEmpleado", A25apellidoEmpleado);
            A26nombreEmpleado = T00043_A26nombreEmpleado[0];
            AssignAttri("", false, "A26nombreEmpleado", A26nombreEmpleado);
            A27telefonoEmpleado = T00043_A27telefonoEmpleado[0];
            AssignAttri("", false, "A27telefonoEmpleado", A27telefonoEmpleado);
            A28direccionEmpleado = T00043_A28direccionEmpleado[0];
            AssignAttri("", false, "A28direccionEmpleado", A28direccionEmpleado);
            A13id_Localidad = T00043_A13id_Localidad[0];
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            Z4idEmpleado = A4idEmpleado;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load044( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey044( ) ;
            }
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey044( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey044( ) ;
         if ( RcdFound4 == 0 )
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
         RcdFound4 = 0;
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A4idEmpleado});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00048_A4idEmpleado[0] < A4idEmpleado ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00048_A4idEmpleado[0] > A4idEmpleado ) ) )
            {
               A4idEmpleado = T00048_A4idEmpleado[0];
               AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
               RcdFound4 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A4idEmpleado});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00049_A4idEmpleado[0] > A4idEmpleado ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00049_A4idEmpleado[0] < A4idEmpleado ) ) )
            {
               A4idEmpleado = T00049_A4idEmpleado[0];
               AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
               RcdFound4 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey044( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtidEmpleado_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert044( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A4idEmpleado != Z4idEmpleado )
               {
                  A4idEmpleado = Z4idEmpleado;
                  AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDEMPLEADO");
                  AnyError = 1;
                  GX_FocusControl = edtidEmpleado_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtidEmpleado_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update044( ) ;
                  GX_FocusControl = edtidEmpleado_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A4idEmpleado != Z4idEmpleado )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtidEmpleado_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert044( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDEMPLEADO");
                     AnyError = 1;
                     GX_FocusControl = edtidEmpleado_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtidEmpleado_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert044( ) ;
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
         if ( A4idEmpleado != Z4idEmpleado )
         {
            A4idEmpleado = Z4idEmpleado;
            AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDEMPLEADO");
            AnyError = 1;
            GX_FocusControl = edtidEmpleado_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtidEmpleado_Internalname;
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
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "IDEMPLEADO");
            AnyError = 1;
            GX_FocusControl = edtidEmpleado_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtdniEmpleado_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniEmpleado_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd044( ) ;
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
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniEmpleado_Internalname;
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
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniEmpleado_Internalname;
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
         ScanStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound4 != 0 )
            {
               ScanNext044( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdniEmpleado_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd044( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency044( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A4idEmpleado});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Empleado"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z24dniEmpleado != T00042_A24dniEmpleado[0] ) || ( StringUtil.StrCmp(Z25apellidoEmpleado, T00042_A25apellidoEmpleado[0]) != 0 ) || ( StringUtil.StrCmp(Z26nombreEmpleado, T00042_A26nombreEmpleado[0]) != 0 ) || ( StringUtil.StrCmp(Z27telefonoEmpleado, T00042_A27telefonoEmpleado[0]) != 0 ) || ( StringUtil.StrCmp(Z28direccionEmpleado, T00042_A28direccionEmpleado[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z13id_Localidad != T00042_A13id_Localidad[0] ) )
            {
               if ( Z24dniEmpleado != T00042_A24dniEmpleado[0] )
               {
                  GXUtil.WriteLog("empleado:[seudo value changed for attri]"+"dniEmpleado");
                  GXUtil.WriteLogRaw("Old: ",Z24dniEmpleado);
                  GXUtil.WriteLogRaw("Current: ",T00042_A24dniEmpleado[0]);
               }
               if ( StringUtil.StrCmp(Z25apellidoEmpleado, T00042_A25apellidoEmpleado[0]) != 0 )
               {
                  GXUtil.WriteLog("empleado:[seudo value changed for attri]"+"apellidoEmpleado");
                  GXUtil.WriteLogRaw("Old: ",Z25apellidoEmpleado);
                  GXUtil.WriteLogRaw("Current: ",T00042_A25apellidoEmpleado[0]);
               }
               if ( StringUtil.StrCmp(Z26nombreEmpleado, T00042_A26nombreEmpleado[0]) != 0 )
               {
                  GXUtil.WriteLog("empleado:[seudo value changed for attri]"+"nombreEmpleado");
                  GXUtil.WriteLogRaw("Old: ",Z26nombreEmpleado);
                  GXUtil.WriteLogRaw("Current: ",T00042_A26nombreEmpleado[0]);
               }
               if ( StringUtil.StrCmp(Z27telefonoEmpleado, T00042_A27telefonoEmpleado[0]) != 0 )
               {
                  GXUtil.WriteLog("empleado:[seudo value changed for attri]"+"telefonoEmpleado");
                  GXUtil.WriteLogRaw("Old: ",Z27telefonoEmpleado);
                  GXUtil.WriteLogRaw("Current: ",T00042_A27telefonoEmpleado[0]);
               }
               if ( StringUtil.StrCmp(Z28direccionEmpleado, T00042_A28direccionEmpleado[0]) != 0 )
               {
                  GXUtil.WriteLog("empleado:[seudo value changed for attri]"+"direccionEmpleado");
                  GXUtil.WriteLogRaw("Old: ",Z28direccionEmpleado);
                  GXUtil.WriteLogRaw("Current: ",T00042_A28direccionEmpleado[0]);
               }
               if ( Z13id_Localidad != T00042_A13id_Localidad[0] )
               {
                  GXUtil.WriteLog("empleado:[seudo value changed for attri]"+"id_Localidad");
                  GXUtil.WriteLogRaw("Old: ",Z13id_Localidad);
                  GXUtil.WriteLogRaw("Current: ",T00042_A13id_Localidad[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Empleado"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM044( 0) ;
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000410 */
                     pr_default.execute(8, new Object[] {A4idEmpleado, A24dniEmpleado, A25apellidoEmpleado, A26nombreEmpleado, A27telefonoEmpleado, A28direccionEmpleado, A13id_Localidad});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Empleado") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption040( ) ;
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
               Load044( ) ;
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void Update044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000411 */
                     pr_default.execute(9, new Object[] {A24dniEmpleado, A25apellidoEmpleado, A26nombreEmpleado, A27telefonoEmpleado, A28direccionEmpleado, A13id_Localidad, A4idEmpleado});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Empleado") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Empleado"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate044( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption040( ) ;
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
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void DeferredUpdate044( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls044( ) ;
            AfterConfirm044( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete044( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000412 */
                  pr_default.execute(10, new Object[] {A4idEmpleado});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Empleado") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound4 == 0 )
                        {
                           InitAll044( ) ;
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
                        ResetCaption040( ) ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel044( ) ;
         Gx_mode = sMode4;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls044( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000413 */
            pr_default.execute(11, new Object[] {A13id_Localidad});
            A50nombreLocalidad = T000413_A50nombreLocalidad[0];
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            pr_default.close(11);
         }
      }

      protected void EndLevel044( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("empleado",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("empleado",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart044( )
      {
         /* Using cursor T000414 */
         pr_default.execute(12);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A4idEmpleado = T000414_A4idEmpleado[0];
            AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext044( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A4idEmpleado = T000414_A4idEmpleado[0];
            AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
         }
      }

      protected void ScanEnd044( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm044( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert044( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate044( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete044( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete044( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate044( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes044( )
      {
         edtidEmpleado_Enabled = 0;
         AssignProp("", false, edtidEmpleado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidEmpleado_Enabled), 5, 0), true);
         edtdniEmpleado_Enabled = 0;
         AssignProp("", false, edtdniEmpleado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdniEmpleado_Enabled), 5, 0), true);
         edtapellidoEmpleado_Enabled = 0;
         AssignProp("", false, edtapellidoEmpleado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtapellidoEmpleado_Enabled), 5, 0), true);
         edtnombreEmpleado_Enabled = 0;
         AssignProp("", false, edtnombreEmpleado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreEmpleado_Enabled), 5, 0), true);
         edttelefonoEmpleado_Enabled = 0;
         AssignProp("", false, edttelefonoEmpleado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttelefonoEmpleado_Enabled), 5, 0), true);
         edtdireccionEmpleado_Enabled = 0;
         AssignProp("", false, edtdireccionEmpleado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdireccionEmpleado_Enabled), 5, 0), true);
         edtid_Localidad_Enabled = 0;
         AssignProp("", false, edtid_Localidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtid_Localidad_Enabled), 5, 0), true);
         edtnombreLocalidad_Enabled = 0;
         AssignProp("", false, edtnombreLocalidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreLocalidad_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes044( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues040( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020716133247", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("empleado.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z4idEmpleado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4idEmpleado), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24dniEmpleado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24dniEmpleado), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z25apellidoEmpleado", Z25apellidoEmpleado);
         GxWebStd.gx_hidden_field( context, "Z26nombreEmpleado", Z26nombreEmpleado);
         GxWebStd.gx_hidden_field( context, "Z27telefonoEmpleado", StringUtil.RTrim( Z27telefonoEmpleado));
         GxWebStd.gx_hidden_field( context, "Z28direccionEmpleado", Z28direccionEmpleado);
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
         return formatLink("empleado.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Empleado" ;
      }

      public override String GetPgmdesc( )
      {
         return "Empleado" ;
      }

      protected void InitializeNonKey044( )
      {
         A24dniEmpleado = 0;
         AssignAttri("", false, "A24dniEmpleado", StringUtil.LTrimStr( (decimal)(A24dniEmpleado), 4, 0));
         A25apellidoEmpleado = "";
         AssignAttri("", false, "A25apellidoEmpleado", A25apellidoEmpleado);
         A26nombreEmpleado = "";
         AssignAttri("", false, "A26nombreEmpleado", A26nombreEmpleado);
         A27telefonoEmpleado = "";
         AssignAttri("", false, "A27telefonoEmpleado", A27telefonoEmpleado);
         A28direccionEmpleado = "";
         AssignAttri("", false, "A28direccionEmpleado", A28direccionEmpleado);
         A13id_Localidad = 0;
         AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
         A50nombreLocalidad = "";
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         Z24dniEmpleado = 0;
         Z25apellidoEmpleado = "";
         Z26nombreEmpleado = "";
         Z27telefonoEmpleado = "";
         Z28direccionEmpleado = "";
         Z13id_Localidad = 0;
      }

      protected void InitAll044( )
      {
         A4idEmpleado = 0;
         AssignAttri("", false, "A4idEmpleado", StringUtil.LTrimStr( (decimal)(A4idEmpleado), 4, 0));
         InitializeNonKey044( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020716133252", true, true);
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
         context.AddJavascriptSource("empleado.js", "?2020716133252", false, true);
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
         edtidEmpleado_Internalname = "IDEMPLEADO";
         edtdniEmpleado_Internalname = "DNIEMPLEADO";
         edtapellidoEmpleado_Internalname = "APELLIDOEMPLEADO";
         edtnombreEmpleado_Internalname = "NOMBREEMPLEADO";
         edttelefonoEmpleado_Internalname = "TELEFONOEMPLEADO";
         edtdireccionEmpleado_Internalname = "DIRECCIONEMPLEADO";
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
         Form.Caption = "Empleado";
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
         edtdireccionEmpleado_Enabled = 1;
         edttelefonoEmpleado_Jsonclick = "";
         edttelefonoEmpleado_Enabled = 1;
         edtnombreEmpleado_Jsonclick = "";
         edtnombreEmpleado_Enabled = 1;
         edtapellidoEmpleado_Jsonclick = "";
         edtapellidoEmpleado_Enabled = 1;
         edtdniEmpleado_Jsonclick = "";
         edtdniEmpleado_Enabled = 1;
         edtidEmpleado_Jsonclick = "";
         edtidEmpleado_Enabled = 1;
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
         GX_FocusControl = edtdniEmpleado_Internalname;
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

      public void Valid_Idempleado( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A24dniEmpleado", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24dniEmpleado), 4, 0, ".", "")));
         AssignAttri("", false, "A25apellidoEmpleado", A25apellidoEmpleado);
         AssignAttri("", false, "A26nombreEmpleado", A26nombreEmpleado);
         AssignAttri("", false, "A27telefonoEmpleado", StringUtil.RTrim( A27telefonoEmpleado));
         AssignAttri("", false, "A28direccionEmpleado", A28direccionEmpleado);
         AssignAttri("", false, "A13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13id_Localidad), 4, 0, ".", "")));
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z4idEmpleado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4idEmpleado), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24dniEmpleado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24dniEmpleado), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z25apellidoEmpleado", Z25apellidoEmpleado);
         GxWebStd.gx_hidden_field( context, "Z26nombreEmpleado", Z26nombreEmpleado);
         GxWebStd.gx_hidden_field( context, "Z27telefonoEmpleado", StringUtil.RTrim( Z27telefonoEmpleado));
         GxWebStd.gx_hidden_field( context, "Z28direccionEmpleado", Z28direccionEmpleado);
         GxWebStd.gx_hidden_field( context, "Z13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13id_Localidad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z50nombreLocalidad", Z50nombreLocalidad);
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Id_localidad( )
      {
         /* Using cursor T000413 */
         pr_default.execute(11, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
         }
         A50nombreLocalidad = T000413_A50nombreLocalidad[0];
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
         setEventMetadata("VALID_IDEMPLEADO","{handler:'Valid_Idempleado',iparms:[{av:'A4idEmpleado',fld:'IDEMPLEADO',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_IDEMPLEADO",",oparms:[{av:'A24dniEmpleado',fld:'DNIEMPLEADO',pic:'ZZZ9'},{av:'A25apellidoEmpleado',fld:'APELLIDOEMPLEADO',pic:''},{av:'A26nombreEmpleado',fld:'NOMBREEMPLEADO',pic:''},{av:'A27telefonoEmpleado',fld:'TELEFONOEMPLEADO',pic:''},{av:'A28direccionEmpleado',fld:'DIRECCIONEMPLEADO',pic:''},{av:'A13id_Localidad',fld:'ID_LOCALIDAD',pic:'ZZZ9'},{av:'A50nombreLocalidad',fld:'NOMBRELOCALIDAD',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z4idEmpleado'},{av:'Z24dniEmpleado'},{av:'Z25apellidoEmpleado'},{av:'Z26nombreEmpleado'},{av:'Z27telefonoEmpleado'},{av:'Z28direccionEmpleado'},{av:'Z13id_Localidad'},{av:'Z50nombreLocalidad'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
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
         Z25apellidoEmpleado = "";
         Z26nombreEmpleado = "";
         Z27telefonoEmpleado = "";
         Z28direccionEmpleado = "";
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
         A25apellidoEmpleado = "";
         A26nombreEmpleado = "";
         gxphoneLink = "";
         A27telefonoEmpleado = "";
         A28direccionEmpleado = "";
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
         T00045_A4idEmpleado = new short[1] ;
         T00045_A24dniEmpleado = new short[1] ;
         T00045_A25apellidoEmpleado = new String[] {""} ;
         T00045_A26nombreEmpleado = new String[] {""} ;
         T00045_A27telefonoEmpleado = new String[] {""} ;
         T00045_A28direccionEmpleado = new String[] {""} ;
         T00045_A50nombreLocalidad = new String[] {""} ;
         T00045_A13id_Localidad = new short[1] ;
         T00044_A50nombreLocalidad = new String[] {""} ;
         T00046_A50nombreLocalidad = new String[] {""} ;
         T00047_A4idEmpleado = new short[1] ;
         T00043_A4idEmpleado = new short[1] ;
         T00043_A24dniEmpleado = new short[1] ;
         T00043_A25apellidoEmpleado = new String[] {""} ;
         T00043_A26nombreEmpleado = new String[] {""} ;
         T00043_A27telefonoEmpleado = new String[] {""} ;
         T00043_A28direccionEmpleado = new String[] {""} ;
         T00043_A13id_Localidad = new short[1] ;
         sMode4 = "";
         T00048_A4idEmpleado = new short[1] ;
         T00049_A4idEmpleado = new short[1] ;
         T00042_A4idEmpleado = new short[1] ;
         T00042_A24dniEmpleado = new short[1] ;
         T00042_A25apellidoEmpleado = new String[] {""} ;
         T00042_A26nombreEmpleado = new String[] {""} ;
         T00042_A27telefonoEmpleado = new String[] {""} ;
         T00042_A28direccionEmpleado = new String[] {""} ;
         T00042_A13id_Localidad = new short[1] ;
         T000413_A50nombreLocalidad = new String[] {""} ;
         T000414_A4idEmpleado = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ25apellidoEmpleado = "";
         ZZ26nombreEmpleado = "";
         ZZ27telefonoEmpleado = "";
         ZZ28direccionEmpleado = "";
         ZZ50nombreLocalidad = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empleado__default(),
            new Object[][] {
                new Object[] {
               T00042_A4idEmpleado, T00042_A24dniEmpleado, T00042_A25apellidoEmpleado, T00042_A26nombreEmpleado, T00042_A27telefonoEmpleado, T00042_A28direccionEmpleado, T00042_A13id_Localidad
               }
               , new Object[] {
               T00043_A4idEmpleado, T00043_A24dniEmpleado, T00043_A25apellidoEmpleado, T00043_A26nombreEmpleado, T00043_A27telefonoEmpleado, T00043_A28direccionEmpleado, T00043_A13id_Localidad
               }
               , new Object[] {
               T00044_A50nombreLocalidad
               }
               , new Object[] {
               T00045_A4idEmpleado, T00045_A24dniEmpleado, T00045_A25apellidoEmpleado, T00045_A26nombreEmpleado, T00045_A27telefonoEmpleado, T00045_A28direccionEmpleado, T00045_A50nombreLocalidad, T00045_A13id_Localidad
               }
               , new Object[] {
               T00046_A50nombreLocalidad
               }
               , new Object[] {
               T00047_A4idEmpleado
               }
               , new Object[] {
               T00048_A4idEmpleado
               }
               , new Object[] {
               T00049_A4idEmpleado
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000413_A50nombreLocalidad
               }
               , new Object[] {
               T000414_A4idEmpleado
               }
            }
         );
      }

      private short Z4idEmpleado ;
      private short Z24dniEmpleado ;
      private short Z13id_Localidad ;
      private short GxWebError ;
      private short A13id_Localidad ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A4idEmpleado ;
      private short A24dniEmpleado ;
      private short GX_JID ;
      private short RcdFound4 ;
      private short nIsDirty_4 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ4idEmpleado ;
      private short ZZ24dniEmpleado ;
      private short ZZ13id_Localidad ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtidEmpleado_Enabled ;
      private int edtdniEmpleado_Enabled ;
      private int edtapellidoEmpleado_Enabled ;
      private int edtnombreEmpleado_Enabled ;
      private int edttelefonoEmpleado_Enabled ;
      private int edtdireccionEmpleado_Enabled ;
      private int edtid_Localidad_Enabled ;
      private int imgprompt_13_Visible ;
      private int edtnombreLocalidad_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String Z27telefonoEmpleado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtidEmpleado_Internalname ;
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
      private String edtidEmpleado_Jsonclick ;
      private String edtdniEmpleado_Internalname ;
      private String edtdniEmpleado_Jsonclick ;
      private String edtapellidoEmpleado_Internalname ;
      private String edtapellidoEmpleado_Jsonclick ;
      private String edtnombreEmpleado_Internalname ;
      private String edtnombreEmpleado_Jsonclick ;
      private String edttelefonoEmpleado_Internalname ;
      private String gxphoneLink ;
      private String A27telefonoEmpleado ;
      private String edttelefonoEmpleado_Jsonclick ;
      private String edtdireccionEmpleado_Internalname ;
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
      private String sMode4 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String ZZ27telefonoEmpleado ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String Z25apellidoEmpleado ;
      private String Z26nombreEmpleado ;
      private String Z28direccionEmpleado ;
      private String A25apellidoEmpleado ;
      private String A26nombreEmpleado ;
      private String A28direccionEmpleado ;
      private String A50nombreLocalidad ;
      private String Z50nombreLocalidad ;
      private String ZZ25apellidoEmpleado ;
      private String ZZ26nombreEmpleado ;
      private String ZZ28direccionEmpleado ;
      private String ZZ50nombreLocalidad ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00045_A4idEmpleado ;
      private short[] T00045_A24dniEmpleado ;
      private String[] T00045_A25apellidoEmpleado ;
      private String[] T00045_A26nombreEmpleado ;
      private String[] T00045_A27telefonoEmpleado ;
      private String[] T00045_A28direccionEmpleado ;
      private String[] T00045_A50nombreLocalidad ;
      private short[] T00045_A13id_Localidad ;
      private String[] T00044_A50nombreLocalidad ;
      private String[] T00046_A50nombreLocalidad ;
      private short[] T00047_A4idEmpleado ;
      private short[] T00043_A4idEmpleado ;
      private short[] T00043_A24dniEmpleado ;
      private String[] T00043_A25apellidoEmpleado ;
      private String[] T00043_A26nombreEmpleado ;
      private String[] T00043_A27telefonoEmpleado ;
      private String[] T00043_A28direccionEmpleado ;
      private short[] T00043_A13id_Localidad ;
      private short[] T00048_A4idEmpleado ;
      private short[] T00049_A4idEmpleado ;
      private short[] T00042_A4idEmpleado ;
      private short[] T00042_A24dniEmpleado ;
      private String[] T00042_A25apellidoEmpleado ;
      private String[] T00042_A26nombreEmpleado ;
      private String[] T00042_A27telefonoEmpleado ;
      private String[] T00042_A28direccionEmpleado ;
      private short[] T00042_A13id_Localidad ;
      private String[] T000413_A50nombreLocalidad ;
      private short[] T000414_A4idEmpleado ;
      private GXWebForm Form ;
   }

   public class empleado__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@dniEmpleado",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@apellidoEmpleado",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@nombreEmpleado",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@telefonoEmpleado",SqlDbType.NChar,20,0} ,
          new Object[] {"@direccionEmpleado",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@dniEmpleado",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@apellidoEmpleado",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@nombreEmpleado",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@telefonoEmpleado",SqlDbType.NChar,20,0} ,
          new Object[] {"@direccionEmpleado",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@idEmpleado",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [idEmpleado], [dniEmpleado], [apellidoEmpleado], [nombreEmpleado], [telefonoEmpleado], [direccionEmpleado], [id_Localidad] FROM [Empleado] WITH (UPDLOCK) WHERE [idEmpleado] = @idEmpleado ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00043", "SELECT [idEmpleado], [dniEmpleado], [apellidoEmpleado], [nombreEmpleado], [telefonoEmpleado], [direccionEmpleado], [id_Localidad] FROM [Empleado] WHERE [idEmpleado] = @idEmpleado ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00044", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00045", "SELECT TM1.[idEmpleado], TM1.[dniEmpleado], TM1.[apellidoEmpleado], TM1.[nombreEmpleado], TM1.[telefonoEmpleado], TM1.[direccionEmpleado], T2.[nombreLocalidad], TM1.[id_Localidad] FROM ([Empleado] TM1 INNER JOIN [Localidad] T2 ON T2.[id_Localidad] = TM1.[id_Localidad]) WHERE TM1.[idEmpleado] = @idEmpleado ORDER BY TM1.[idEmpleado]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00046", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00047", "SELECT [idEmpleado] FROM [Empleado] WHERE [idEmpleado] = @idEmpleado  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00048", "SELECT TOP 1 [idEmpleado] FROM [Empleado] WHERE ( [idEmpleado] > @idEmpleado) ORDER BY [idEmpleado]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00049", "SELECT TOP 1 [idEmpleado] FROM [Empleado] WHERE ( [idEmpleado] < @idEmpleado) ORDER BY [idEmpleado] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000410", "INSERT INTO [Empleado]([idEmpleado], [dniEmpleado], [apellidoEmpleado], [nombreEmpleado], [telefonoEmpleado], [direccionEmpleado], [id_Localidad]) VALUES(@idEmpleado, @dniEmpleado, @apellidoEmpleado, @nombreEmpleado, @telefonoEmpleado, @direccionEmpleado, @id_Localidad)", GxErrorMask.GX_NOMASK,prmT000410)
             ,new CursorDef("T000411", "UPDATE [Empleado] SET [dniEmpleado]=@dniEmpleado, [apellidoEmpleado]=@apellidoEmpleado, [nombreEmpleado]=@nombreEmpleado, [telefonoEmpleado]=@telefonoEmpleado, [direccionEmpleado]=@direccionEmpleado, [id_Localidad]=@id_Localidad  WHERE [idEmpleado] = @idEmpleado", GxErrorMask.GX_NOMASK,prmT000411)
             ,new CursorDef("T000412", "DELETE FROM [Empleado]  WHERE [idEmpleado] = @idEmpleado", GxErrorMask.GX_NOMASK,prmT000412)
             ,new CursorDef("T000413", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000414", "SELECT [idEmpleado] FROM [Empleado] ORDER BY [idEmpleado]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,100, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 12 :
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
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
       }
    }

 }

}
