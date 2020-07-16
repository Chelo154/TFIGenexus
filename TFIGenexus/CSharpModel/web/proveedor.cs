/*
               File: Proveedor
        Description: Proveedor
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:2:58.61
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
   public class proveedor : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "Proveedor", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtidProveedor_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public proveedor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public proveedor( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Proveedor", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Proveedor.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPROVEEDOR"+"'), id:'"+"IDPROVEEDOR"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Proveedor.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidProveedor_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidProveedor_Internalname, "Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidProveedor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2idProveedor), 4, 0, ".", "")), ((edtidProveedor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A2idProveedor), "ZZZ9")) : context.localUtil.Format( (decimal)(A2idProveedor), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidProveedor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidProveedor_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtcuitProveedor_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtcuitProveedor_Internalname, "Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtcuitProveedor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A52cuitProveedor), 10, 0, ".", "")), ((edtcuitProveedor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A52cuitProveedor), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A52cuitProveedor), "ZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcuitProveedor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtcuitProveedor_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtnombreProveedor_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtnombreProveedor_Internalname, "Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtnombreProveedor_Internalname, A16nombreProveedor, StringUtil.RTrim( context.localUtil.Format( A16nombreProveedor, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreProveedor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreProveedor_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdireccionProveedor_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtdireccionProveedor_Internalname, "Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtdireccionProveedor_Internalname, A17direccionProveedor, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A17direccionProveedor), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", 0, 1, edtdireccionProveedor_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttelefonoProveedor_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttelefonoProveedor_Internalname, "Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         if ( context.isSmartDevice( ) )
         {
            gxphoneLink = "tel:" + StringUtil.RTrim( A18telefonoProveedor);
         }
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edttelefonoProveedor_Internalname, StringUtil.RTrim( A18telefonoProveedor), StringUtil.RTrim( context.localUtil.Format( A18telefonoProveedor, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", gxphoneLink, "", "", "", edttelefonoProveedor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttelefonoProveedor_Enabled, 0, "tel", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Phone", "left", true, "", "HLP_Proveedor.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtid_Localidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13id_Localidad), 4, 0, ".", "")), ((edtid_Localidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13id_Localidad), "ZZZ9")) : context.localUtil.Format( (decimal)(A13id_Localidad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtid_Localidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtid_Localidad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Proveedor.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_13_Internalname, sImgUrl, imgprompt_13_Link, "", "", context.GetTheme( ), imgprompt_13_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Proveedor.htm");
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
         GxWebStd.gx_single_line_edit( context, edtnombreLocalidad_Internalname, A50nombreLocalidad, StringUtil.RTrim( context.localUtil.Format( A50nombreLocalidad, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreLocalidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreLocalidad_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Proveedor.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proveedor.htm");
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
            Z2idProveedor = (short)(context.localUtil.CToN( cgiGet( "Z2idProveedor"), ".", ","));
            Z52cuitProveedor = (long)(context.localUtil.CToN( cgiGet( "Z52cuitProveedor"), ".", ","));
            Z16nombreProveedor = cgiGet( "Z16nombreProveedor");
            Z17direccionProveedor = cgiGet( "Z17direccionProveedor");
            Z18telefonoProveedor = cgiGet( "Z18telefonoProveedor");
            Z13id_Localidad = (short)(context.localUtil.CToN( cgiGet( "Z13id_Localidad"), ".", ","));
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtidProveedor_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidProveedor_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDPROVEEDOR");
               AnyError = 1;
               GX_FocusControl = edtidProveedor_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A2idProveedor = 0;
               AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            }
            else
            {
               A2idProveedor = (short)(context.localUtil.CToN( cgiGet( edtidProveedor_Internalname), ".", ","));
               AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtcuitProveedor_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcuitProveedor_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CUITPROVEEDOR");
               AnyError = 1;
               GX_FocusControl = edtcuitProveedor_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A52cuitProveedor = 0;
               AssignAttri("", false, "A52cuitProveedor", StringUtil.LTrimStr( (decimal)(A52cuitProveedor), 10, 0));
            }
            else
            {
               A52cuitProveedor = (long)(context.localUtil.CToN( cgiGet( edtcuitProveedor_Internalname), ".", ","));
               AssignAttri("", false, "A52cuitProveedor", StringUtil.LTrimStr( (decimal)(A52cuitProveedor), 10, 0));
            }
            A16nombreProveedor = cgiGet( edtnombreProveedor_Internalname);
            AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
            A17direccionProveedor = cgiGet( edtdireccionProveedor_Internalname);
            AssignAttri("", false, "A17direccionProveedor", A17direccionProveedor);
            A18telefonoProveedor = cgiGet( edttelefonoProveedor_Internalname);
            AssignAttri("", false, "A18telefonoProveedor", A18telefonoProveedor);
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
               A2idProveedor = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
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
               InitAll022( ) ;
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
         DisableAttributes022( ) ;
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

      protected void ResetCaption020( )
      {
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z52cuitProveedor = T00023_A52cuitProveedor[0];
               Z16nombreProveedor = T00023_A16nombreProveedor[0];
               Z17direccionProveedor = T00023_A17direccionProveedor[0];
               Z18telefonoProveedor = T00023_A18telefonoProveedor[0];
               Z13id_Localidad = T00023_A13id_Localidad[0];
            }
            else
            {
               Z52cuitProveedor = A52cuitProveedor;
               Z16nombreProveedor = A16nombreProveedor;
               Z17direccionProveedor = A17direccionProveedor;
               Z18telefonoProveedor = A18telefonoProveedor;
               Z13id_Localidad = A13id_Localidad;
            }
         }
         if ( GX_JID == -1 )
         {
            Z2idProveedor = A2idProveedor;
            Z52cuitProveedor = A52cuitProveedor;
            Z16nombreProveedor = A16nombreProveedor;
            Z17direccionProveedor = A17direccionProveedor;
            Z18telefonoProveedor = A18telefonoProveedor;
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

      protected void Load022( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1;
            A52cuitProveedor = T00025_A52cuitProveedor[0];
            AssignAttri("", false, "A52cuitProveedor", StringUtil.LTrimStr( (decimal)(A52cuitProveedor), 10, 0));
            A16nombreProveedor = T00025_A16nombreProveedor[0];
            AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
            A17direccionProveedor = T00025_A17direccionProveedor[0];
            AssignAttri("", false, "A17direccionProveedor", A17direccionProveedor);
            A18telefonoProveedor = T00025_A18telefonoProveedor[0];
            AssignAttri("", false, "A18telefonoProveedor", A18telefonoProveedor);
            A50nombreLocalidad = T00025_A50nombreLocalidad[0];
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            A13id_Localidad = T00025_A13id_Localidad[0];
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            ZM022( -1) ;
         }
         pr_default.close(3);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50nombreLocalidad = T00024_A50nombreLocalidad[0];
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A13id_Localidad )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A50nombreLocalidad = T00026_A50nombreLocalidad[0];
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

      protected void GetKey022( )
      {
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 1) ;
            RcdFound2 = 1;
            A2idProveedor = T00023_A2idProveedor[0];
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            A52cuitProveedor = T00023_A52cuitProveedor[0];
            AssignAttri("", false, "A52cuitProveedor", StringUtil.LTrimStr( (decimal)(A52cuitProveedor), 10, 0));
            A16nombreProveedor = T00023_A16nombreProveedor[0];
            AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
            A17direccionProveedor = T00023_A17direccionProveedor[0];
            AssignAttri("", false, "A17direccionProveedor", A17direccionProveedor);
            A18telefonoProveedor = T00023_A18telefonoProveedor[0];
            AssignAttri("", false, "A18telefonoProveedor", A18telefonoProveedor);
            A13id_Localidad = T00023_A13id_Localidad[0];
            AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
            Z2idProveedor = A2idProveedor;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
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
         RcdFound2 = 0;
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00028_A2idProveedor[0] < A2idProveedor ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00028_A2idProveedor[0] > A2idProveedor ) ) )
            {
               A2idProveedor = T00028_A2idProveedor[0];
               AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
               RcdFound2 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0;
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00029_A2idProveedor[0] > A2idProveedor ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00029_A2idProveedor[0] < A2idProveedor ) ) )
            {
               A2idProveedor = T00029_A2idProveedor[0];
               AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
               RcdFound2 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtidProveedor_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert022( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A2idProveedor != Z2idProveedor )
               {
                  A2idProveedor = Z2idProveedor;
                  AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDPROVEEDOR");
                  AnyError = 1;
                  GX_FocusControl = edtidProveedor_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtidProveedor_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update022( ) ;
                  GX_FocusControl = edtidProveedor_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A2idProveedor != Z2idProveedor )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtidProveedor_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDPROVEEDOR");
                     AnyError = 1;
                     GX_FocusControl = edtidProveedor_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtidProveedor_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert022( ) ;
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
         if ( A2idProveedor != Z2idProveedor )
         {
            A2idProveedor = Z2idProveedor;
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDPROVEEDOR");
            AnyError = 1;
            GX_FocusControl = edtidProveedor_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtidProveedor_Internalname;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "IDPROVEEDOR");
            AnyError = 1;
            GX_FocusControl = edtidProveedor_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtcuitProveedor_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtcuitProveedor_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtcuitProveedor_Internalname;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtcuitProveedor_Internalname;
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
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound2 != 0 )
            {
               ScanNext022( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtcuitProveedor_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A2idProveedor});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proveedor"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z52cuitProveedor != T00022_A52cuitProveedor[0] ) || ( StringUtil.StrCmp(Z16nombreProveedor, T00022_A16nombreProveedor[0]) != 0 ) || ( StringUtil.StrCmp(Z17direccionProveedor, T00022_A17direccionProveedor[0]) != 0 ) || ( StringUtil.StrCmp(Z18telefonoProveedor, T00022_A18telefonoProveedor[0]) != 0 ) || ( Z13id_Localidad != T00022_A13id_Localidad[0] ) )
            {
               if ( Z52cuitProveedor != T00022_A52cuitProveedor[0] )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"cuitProveedor");
                  GXUtil.WriteLogRaw("Old: ",Z52cuitProveedor);
                  GXUtil.WriteLogRaw("Current: ",T00022_A52cuitProveedor[0]);
               }
               if ( StringUtil.StrCmp(Z16nombreProveedor, T00022_A16nombreProveedor[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"nombreProveedor");
                  GXUtil.WriteLogRaw("Old: ",Z16nombreProveedor);
                  GXUtil.WriteLogRaw("Current: ",T00022_A16nombreProveedor[0]);
               }
               if ( StringUtil.StrCmp(Z17direccionProveedor, T00022_A17direccionProveedor[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"direccionProveedor");
                  GXUtil.WriteLogRaw("Old: ",Z17direccionProveedor);
                  GXUtil.WriteLogRaw("Current: ",T00022_A17direccionProveedor[0]);
               }
               if ( StringUtil.StrCmp(Z18telefonoProveedor, T00022_A18telefonoProveedor[0]) != 0 )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"telefonoProveedor");
                  GXUtil.WriteLogRaw("Old: ",Z18telefonoProveedor);
                  GXUtil.WriteLogRaw("Current: ",T00022_A18telefonoProveedor[0]);
               }
               if ( Z13id_Localidad != T00022_A13id_Localidad[0] )
               {
                  GXUtil.WriteLog("proveedor:[seudo value changed for attri]"+"id_Localidad");
                  GXUtil.WriteLogRaw("Old: ",Z13id_Localidad);
                  GXUtil.WriteLogRaw("Current: ",T00022_A13id_Localidad[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Proveedor"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000210 */
                     pr_default.execute(8, new Object[] {A52cuitProveedor, A16nombreProveedor, A17direccionProveedor, A18telefonoProveedor, A13id_Localidad});
                     A2idProveedor = T000210_A2idProveedor[0];
                     AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Proveedor") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000211 */
                     pr_default.execute(9, new Object[] {A52cuitProveedor, A16nombreProveedor, A17direccionProveedor, A18telefonoProveedor, A13id_Localidad, A2idProveedor});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Proveedor") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proveedor"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption020( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000212 */
                  pr_default.execute(10, new Object[] {A2idProveedor});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Proveedor") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound2 == 0 )
                        {
                           InitAll022( ) ;
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
                        ResetCaption020( ) ;
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel022( ) ;
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000213 */
            pr_default.execute(11, new Object[] {A13id_Localidad});
            A50nombreLocalidad = T000213_A50nombreLocalidad[0];
            AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000214 */
            pr_default.execute(12, new Object[] {A2idProveedor});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Compra"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel022( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("proveedor",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("proveedor",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart022( )
      {
         /* Using cursor T000215 */
         pr_default.execute(13);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound2 = 1;
            A2idProveedor = T000215_A2idProveedor[0];
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound2 = 1;
            A2idProveedor = T000215_A2idProveedor[0];
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
         }
      }

      protected void ScanEnd022( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtidProveedor_Enabled = 0;
         AssignProp("", false, edtidProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProveedor_Enabled), 5, 0), true);
         edtcuitProveedor_Enabled = 0;
         AssignProp("", false, edtcuitProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtcuitProveedor_Enabled), 5, 0), true);
         edtnombreProveedor_Enabled = 0;
         AssignProp("", false, edtnombreProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreProveedor_Enabled), 5, 0), true);
         edtdireccionProveedor_Enabled = 0;
         AssignProp("", false, edtdireccionProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdireccionProveedor_Enabled), 5, 0), true);
         edttelefonoProveedor_Enabled = 0;
         AssignProp("", false, edttelefonoProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttelefonoProveedor_Enabled), 5, 0), true);
         edtid_Localidad_Enabled = 0;
         AssignProp("", false, edtid_Localidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtid_Localidad_Enabled), 5, 0), true);
         edtnombreLocalidad_Enabled = 0;
         AssignProp("", false, edtnombreLocalidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreLocalidad_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.AddJavascriptSource("gxcfg.js", "?20207161325913", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("proveedor.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z2idProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2idProveedor), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z52cuitProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52cuitProveedor), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z16nombreProveedor", Z16nombreProveedor);
         GxWebStd.gx_hidden_field( context, "Z17direccionProveedor", Z17direccionProveedor);
         GxWebStd.gx_hidden_field( context, "Z18telefonoProveedor", StringUtil.RTrim( Z18telefonoProveedor));
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
         return formatLink("proveedor.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Proveedor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Proveedor" ;
      }

      protected void InitializeNonKey022( )
      {
         A52cuitProveedor = 0;
         AssignAttri("", false, "A52cuitProveedor", StringUtil.LTrimStr( (decimal)(A52cuitProveedor), 10, 0));
         A16nombreProveedor = "";
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
         A17direccionProveedor = "";
         AssignAttri("", false, "A17direccionProveedor", A17direccionProveedor);
         A18telefonoProveedor = "";
         AssignAttri("", false, "A18telefonoProveedor", A18telefonoProveedor);
         A13id_Localidad = 0;
         AssignAttri("", false, "A13id_Localidad", StringUtil.LTrimStr( (decimal)(A13id_Localidad), 4, 0));
         A50nombreLocalidad = "";
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         Z52cuitProveedor = 0;
         Z16nombreProveedor = "";
         Z17direccionProveedor = "";
         Z18telefonoProveedor = "";
         Z13id_Localidad = 0;
      }

      protected void InitAll022( )
      {
         A2idProveedor = 0;
         AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
         InitializeNonKey022( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20207161325918", true, true);
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
         context.AddJavascriptSource("proveedor.js", "?20207161325918", false, true);
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
         edtidProveedor_Internalname = "IDPROVEEDOR";
         edtcuitProveedor_Internalname = "CUITPROVEEDOR";
         edtnombreProveedor_Internalname = "NOMBREPROVEEDOR";
         edtdireccionProveedor_Internalname = "DIRECCIONPROVEEDOR";
         edttelefonoProveedor_Internalname = "TELEFONOPROVEEDOR";
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
         Form.Caption = "Proveedor";
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
         edttelefonoProveedor_Jsonclick = "";
         edttelefonoProveedor_Enabled = 1;
         edtdireccionProveedor_Enabled = 1;
         edtnombreProveedor_Jsonclick = "";
         edtnombreProveedor_Enabled = 1;
         edtcuitProveedor_Jsonclick = "";
         edtcuitProveedor_Enabled = 1;
         edtidProveedor_Jsonclick = "";
         edtidProveedor_Enabled = 1;
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
         GX_FocusControl = edtcuitProveedor_Internalname;
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

      public void Valid_Idproveedor( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A52cuitProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52cuitProveedor), 10, 0, ".", "")));
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
         AssignAttri("", false, "A17direccionProveedor", A17direccionProveedor);
         AssignAttri("", false, "A18telefonoProveedor", StringUtil.RTrim( A18telefonoProveedor));
         AssignAttri("", false, "A13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13id_Localidad), 4, 0, ".", "")));
         AssignAttri("", false, "A50nombreLocalidad", A50nombreLocalidad);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z2idProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2idProveedor), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z52cuitProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52cuitProveedor), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z16nombreProveedor", Z16nombreProveedor);
         GxWebStd.gx_hidden_field( context, "Z17direccionProveedor", Z17direccionProveedor);
         GxWebStd.gx_hidden_field( context, "Z18telefonoProveedor", StringUtil.RTrim( Z18telefonoProveedor));
         GxWebStd.gx_hidden_field( context, "Z13id_Localidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13id_Localidad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z50nombreLocalidad", Z50nombreLocalidad);
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Id_localidad( )
      {
         /* Using cursor T000213 */
         pr_default.execute(11, new Object[] {A13id_Localidad});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ID_LOCALIDAD");
            AnyError = 1;
            GX_FocusControl = edtid_Localidad_Internalname;
         }
         A50nombreLocalidad = T000213_A50nombreLocalidad[0];
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
         setEventMetadata("VALID_IDPROVEEDOR","{handler:'Valid_Idproveedor',iparms:[{av:'A2idProveedor',fld:'IDPROVEEDOR',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_IDPROVEEDOR",",oparms:[{av:'A52cuitProveedor',fld:'CUITPROVEEDOR',pic:'ZZZZZZZZZ9'},{av:'A16nombreProveedor',fld:'NOMBREPROVEEDOR',pic:''},{av:'A17direccionProveedor',fld:'DIRECCIONPROVEEDOR',pic:''},{av:'A18telefonoProveedor',fld:'TELEFONOPROVEEDOR',pic:''},{av:'A13id_Localidad',fld:'ID_LOCALIDAD',pic:'ZZZ9'},{av:'A50nombreLocalidad',fld:'NOMBRELOCALIDAD',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z2idProveedor'},{av:'Z52cuitProveedor'},{av:'Z16nombreProveedor'},{av:'Z17direccionProveedor'},{av:'Z18telefonoProveedor'},{av:'Z13id_Localidad'},{av:'Z50nombreLocalidad'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
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
         Z16nombreProveedor = "";
         Z17direccionProveedor = "";
         Z18telefonoProveedor = "";
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
         A16nombreProveedor = "";
         A17direccionProveedor = "";
         gxphoneLink = "";
         A18telefonoProveedor = "";
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
         T00025_A2idProveedor = new short[1] ;
         T00025_A52cuitProveedor = new long[1] ;
         T00025_A16nombreProveedor = new String[] {""} ;
         T00025_A17direccionProveedor = new String[] {""} ;
         T00025_A18telefonoProveedor = new String[] {""} ;
         T00025_A50nombreLocalidad = new String[] {""} ;
         T00025_A13id_Localidad = new short[1] ;
         T00024_A50nombreLocalidad = new String[] {""} ;
         T00026_A50nombreLocalidad = new String[] {""} ;
         T00027_A2idProveedor = new short[1] ;
         T00023_A2idProveedor = new short[1] ;
         T00023_A52cuitProveedor = new long[1] ;
         T00023_A16nombreProveedor = new String[] {""} ;
         T00023_A17direccionProveedor = new String[] {""} ;
         T00023_A18telefonoProveedor = new String[] {""} ;
         T00023_A13id_Localidad = new short[1] ;
         sMode2 = "";
         T00028_A2idProveedor = new short[1] ;
         T00029_A2idProveedor = new short[1] ;
         T00022_A2idProveedor = new short[1] ;
         T00022_A52cuitProveedor = new long[1] ;
         T00022_A16nombreProveedor = new String[] {""} ;
         T00022_A17direccionProveedor = new String[] {""} ;
         T00022_A18telefonoProveedor = new String[] {""} ;
         T00022_A13id_Localidad = new short[1] ;
         T000210_A2idProveedor = new short[1] ;
         T000213_A50nombreLocalidad = new String[] {""} ;
         T000214_A6idCompra = new short[1] ;
         T000215_A2idProveedor = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ16nombreProveedor = "";
         ZZ17direccionProveedor = "";
         ZZ18telefonoProveedor = "";
         ZZ50nombreLocalidad = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proveedor__default(),
            new Object[][] {
                new Object[] {
               T00022_A2idProveedor, T00022_A52cuitProveedor, T00022_A16nombreProveedor, T00022_A17direccionProveedor, T00022_A18telefonoProveedor, T00022_A13id_Localidad
               }
               , new Object[] {
               T00023_A2idProveedor, T00023_A52cuitProveedor, T00023_A16nombreProveedor, T00023_A17direccionProveedor, T00023_A18telefonoProveedor, T00023_A13id_Localidad
               }
               , new Object[] {
               T00024_A50nombreLocalidad
               }
               , new Object[] {
               T00025_A2idProveedor, T00025_A52cuitProveedor, T00025_A16nombreProveedor, T00025_A17direccionProveedor, T00025_A18telefonoProveedor, T00025_A50nombreLocalidad, T00025_A13id_Localidad
               }
               , new Object[] {
               T00026_A50nombreLocalidad
               }
               , new Object[] {
               T00027_A2idProveedor
               }
               , new Object[] {
               T00028_A2idProveedor
               }
               , new Object[] {
               T00029_A2idProveedor
               }
               , new Object[] {
               T000210_A2idProveedor
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000213_A50nombreLocalidad
               }
               , new Object[] {
               T000214_A6idCompra
               }
               , new Object[] {
               T000215_A2idProveedor
               }
            }
         );
      }

      private short Z2idProveedor ;
      private short Z13id_Localidad ;
      private short GxWebError ;
      private short A13id_Localidad ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A2idProveedor ;
      private short GX_JID ;
      private short RcdFound2 ;
      private short nIsDirty_2 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ2idProveedor ;
      private short ZZ13id_Localidad ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtidProveedor_Enabled ;
      private int edtcuitProveedor_Enabled ;
      private int edtnombreProveedor_Enabled ;
      private int edtdireccionProveedor_Enabled ;
      private int edttelefonoProveedor_Enabled ;
      private int edtid_Localidad_Enabled ;
      private int imgprompt_13_Visible ;
      private int edtnombreLocalidad_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z52cuitProveedor ;
      private long A52cuitProveedor ;
      private long ZZ52cuitProveedor ;
      private String sPrefix ;
      private String Z18telefonoProveedor ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtidProveedor_Internalname ;
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
      private String edtidProveedor_Jsonclick ;
      private String edtcuitProveedor_Internalname ;
      private String edtcuitProveedor_Jsonclick ;
      private String edtnombreProveedor_Internalname ;
      private String edtnombreProveedor_Jsonclick ;
      private String edtdireccionProveedor_Internalname ;
      private String edttelefonoProveedor_Internalname ;
      private String gxphoneLink ;
      private String A18telefonoProveedor ;
      private String edttelefonoProveedor_Jsonclick ;
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
      private String sMode2 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String ZZ18telefonoProveedor ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z16nombreProveedor ;
      private String Z17direccionProveedor ;
      private String A16nombreProveedor ;
      private String A17direccionProveedor ;
      private String A50nombreLocalidad ;
      private String Z50nombreLocalidad ;
      private String ZZ16nombreProveedor ;
      private String ZZ17direccionProveedor ;
      private String ZZ50nombreLocalidad ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00025_A2idProveedor ;
      private long[] T00025_A52cuitProveedor ;
      private String[] T00025_A16nombreProveedor ;
      private String[] T00025_A17direccionProveedor ;
      private String[] T00025_A18telefonoProveedor ;
      private String[] T00025_A50nombreLocalidad ;
      private short[] T00025_A13id_Localidad ;
      private String[] T00024_A50nombreLocalidad ;
      private String[] T00026_A50nombreLocalidad ;
      private short[] T00027_A2idProveedor ;
      private short[] T00023_A2idProveedor ;
      private long[] T00023_A52cuitProveedor ;
      private String[] T00023_A16nombreProveedor ;
      private String[] T00023_A17direccionProveedor ;
      private String[] T00023_A18telefonoProveedor ;
      private short[] T00023_A13id_Localidad ;
      private short[] T00028_A2idProveedor ;
      private short[] T00029_A2idProveedor ;
      private short[] T00022_A2idProveedor ;
      private long[] T00022_A52cuitProveedor ;
      private String[] T00022_A16nombreProveedor ;
      private String[] T00022_A17direccionProveedor ;
      private String[] T00022_A18telefonoProveedor ;
      private short[] T00022_A13id_Localidad ;
      private short[] T000210_A2idProveedor ;
      private String[] T000213_A50nombreLocalidad ;
      private short[] T000214_A6idCompra ;
      private short[] T000215_A2idProveedor ;
      private GXWebForm Form ;
   }

   public class proveedor__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@cuitProveedor",SqlDbType.Decimal,10,0} ,
          new Object[] {"@nombreProveedor",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@direccionProveedor",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@telefonoProveedor",SqlDbType.NChar,20,0} ,
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@cuitProveedor",SqlDbType.Decimal,10,0} ,
          new Object[] {"@nombreProveedor",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@direccionProveedor",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@telefonoProveedor",SqlDbType.NChar,20,0} ,
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@id_Localidad",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [idProveedor], [cuitProveedor], [nombreProveedor], [direccionProveedor], [telefonoProveedor], [id_Localidad] FROM [Proveedor] WITH (UPDLOCK) WHERE [idProveedor] = @idProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00023", "SELECT [idProveedor], [cuitProveedor], [nombreProveedor], [direccionProveedor], [telefonoProveedor], [id_Localidad] FROM [Proveedor] WHERE [idProveedor] = @idProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00024", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00025", "SELECT TM1.[idProveedor], TM1.[cuitProveedor], TM1.[nombreProveedor], TM1.[direccionProveedor], TM1.[telefonoProveedor], T2.[nombreLocalidad], TM1.[id_Localidad] FROM ([Proveedor] TM1 INNER JOIN [Localidad] T2 ON T2.[id_Localidad] = TM1.[id_Localidad]) WHERE TM1.[idProveedor] = @idProveedor ORDER BY TM1.[idProveedor]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00026", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00027", "SELECT [idProveedor] FROM [Proveedor] WHERE [idProveedor] = @idProveedor  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00028", "SELECT TOP 1 [idProveedor] FROM [Proveedor] WHERE ( [idProveedor] > @idProveedor) ORDER BY [idProveedor]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00029", "SELECT TOP 1 [idProveedor] FROM [Proveedor] WHERE ( [idProveedor] < @idProveedor) ORDER BY [idProveedor] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000210", "INSERT INTO [Proveedor]([cuitProveedor], [nombreProveedor], [direccionProveedor], [telefonoProveedor], [id_Localidad]) VALUES(@cuitProveedor, @nombreProveedor, @direccionProveedor, @telefonoProveedor, @id_Localidad); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000210)
             ,new CursorDef("T000211", "UPDATE [Proveedor] SET [cuitProveedor]=@cuitProveedor, [nombreProveedor]=@nombreProveedor, [direccionProveedor]=@direccionProveedor, [telefonoProveedor]=@telefonoProveedor, [id_Localidad]=@id_Localidad  WHERE [idProveedor] = @idProveedor", GxErrorMask.GX_NOMASK,prmT000211)
             ,new CursorDef("T000212", "DELETE FROM [Proveedor]  WHERE [idProveedor] = @idProveedor", GxErrorMask.GX_NOMASK,prmT000212)
             ,new CursorDef("T000213", "SELECT [nombreLocalidad] FROM [Localidad] WHERE [id_Localidad] = @id_Localidad ",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000214", "SELECT TOP 1 [idCompra] FROM [Compra] WHERE [idProveedor] = @idProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000215", "SELECT [idProveedor] FROM [Proveedor] ORDER BY [idProveedor]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
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
