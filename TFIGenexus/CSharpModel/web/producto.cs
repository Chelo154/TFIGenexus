/*
               File: Producto
        Description: Producto
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:2:55.48
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
   public class producto : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "Producto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtidProducto_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public producto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public producto( IGxContext context )
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
         cmbtipoProducto = new GXCombobox();
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
         if ( cmbtipoProducto.ItemCount > 0 )
         {
            A22tipoProducto = (short)(NumberUtil.Val( cmbtipoProducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0))), "."));
            AssignAttri("", false, "A22tipoProducto", StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbtipoProducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0));
            AssignProp("", false, cmbtipoProducto_Internalname, "Values", cmbtipoProducto.ToJavascriptSource(), true);
         }
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Producto", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Producto.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPRODUCTO"+"'), id:'"+"IDPRODUCTO"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Producto.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidProducto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidProducto_Internalname, "Producto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")), ((edtidProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9")) : context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidProducto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidProducto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdescripcionProducto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtdescripcionProducto_Internalname, "Producto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtdescripcionProducto_Internalname, A19descripcionProducto, StringUtil.RTrim( context.localUtil.Format( A19descripcionProducto, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdescripcionProducto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdescripcionProducto_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtstockProducto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtstockProducto_Internalname, "Producto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtstockProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20stockProducto), 4, 0, ".", "")), ((edtstockProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20stockProducto), "ZZZ9")) : context.localUtil.Format( (decimal)(A20stockProducto), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstockProducto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtstockProducto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprecioProducto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtprecioProducto_Internalname, "Producto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtprecioProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")), ((edtprecioProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99")) : context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprecioProducto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprecioProducto_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "Precio", "right", false, "", "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbtipoProducto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, cmbtipoProducto_Internalname, "Producto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         /* ComboBox */
         GxWebStd.gx_combobox_ctrl1( context, cmbtipoProducto, cmbtipoProducto_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0)), 1, cmbtipoProducto_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbtipoProducto.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "", true, "HLP_Producto.htm");
         cmbtipoProducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0));
         AssignProp("", false, cmbtipoProducto_Internalname, "Values", (String)(cmbtipoProducto.ToJavascriptSource()), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtstockSeguridad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtstockSeguridad_Internalname, "Seguridad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtstockSeguridad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23stockSeguridad), 4, 0, ".", "")), ((edtstockSeguridad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A23stockSeguridad), "ZZZ9")) : context.localUtil.Format( (decimal)(A23stockSeguridad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstockSeguridad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtstockSeguridad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Producto.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Producto.htm");
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
            Z3idProducto = (short)(context.localUtil.CToN( cgiGet( "Z3idProducto"), ".", ","));
            Z19descripcionProducto = cgiGet( "Z19descripcionProducto");
            Z20stockProducto = (short)(context.localUtil.CToN( cgiGet( "Z20stockProducto"), ".", ","));
            Z21precioProducto = context.localUtil.CToN( cgiGet( "Z21precioProducto"), ".", ",");
            Z22tipoProducto = (short)(context.localUtil.CToN( cgiGet( "Z22tipoProducto"), ".", ","));
            Z23stockSeguridad = (short)(context.localUtil.CToN( cgiGet( "Z23stockSeguridad"), ".", ","));
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDPRODUCTO");
               AnyError = 1;
               GX_FocusControl = edtidProducto_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A3idProducto = 0;
               AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
            }
            else
            {
               A3idProducto = (short)(context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ","));
               AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
            }
            A19descripcionProducto = cgiGet( edtdescripcionProducto_Internalname);
            AssignAttri("", false, "A19descripcionProducto", A19descripcionProducto);
            if ( ( ( context.localUtil.CToN( cgiGet( edtstockProducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockProducto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "STOCKPRODUCTO");
               AnyError = 1;
               GX_FocusControl = edtstockProducto_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A20stockProducto = 0;
               AssignAttri("", false, "A20stockProducto", StringUtil.LTrimStr( (decimal)(A20stockProducto), 4, 0));
            }
            else
            {
               A20stockProducto = (short)(context.localUtil.CToN( cgiGet( edtstockProducto_Internalname), ".", ","));
               AssignAttri("", false, "A20stockProducto", StringUtil.LTrimStr( (decimal)(A20stockProducto), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtprecioProducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtprecioProducto_Internalname), ".", ",") > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PRECIOPRODUCTO");
               AnyError = 1;
               GX_FocusControl = edtprecioProducto_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A21precioProducto = 0;
               AssignAttri("", false, "A21precioProducto", StringUtil.LTrimStr( A21precioProducto, 10, 2));
            }
            else
            {
               A21precioProducto = context.localUtil.CToN( cgiGet( edtprecioProducto_Internalname), ".", ",");
               AssignAttri("", false, "A21precioProducto", StringUtil.LTrimStr( A21precioProducto, 10, 2));
            }
            cmbtipoProducto.CurrentValue = cgiGet( cmbtipoProducto_Internalname);
            A22tipoProducto = (short)(NumberUtil.Val( cgiGet( cmbtipoProducto_Internalname), "."));
            AssignAttri("", false, "A22tipoProducto", StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0));
            if ( ( ( context.localUtil.CToN( cgiGet( edtstockSeguridad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockSeguridad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "STOCKSEGURIDAD");
               AnyError = 1;
               GX_FocusControl = edtstockSeguridad_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A23stockSeguridad = 0;
               AssignAttri("", false, "A23stockSeguridad", StringUtil.LTrimStr( (decimal)(A23stockSeguridad), 4, 0));
            }
            else
            {
               A23stockSeguridad = (short)(context.localUtil.CToN( cgiGet( edtstockSeguridad_Internalname), ".", ","));
               AssignAttri("", false, "A23stockSeguridad", StringUtil.LTrimStr( (decimal)(A23stockSeguridad), 4, 0));
            }
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
               A3idProducto = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
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
               InitAll033( ) ;
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
         DisableAttributes033( ) ;
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

      protected void ResetCaption030( )
      {
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z19descripcionProducto = T00033_A19descripcionProducto[0];
               Z20stockProducto = T00033_A20stockProducto[0];
               Z21precioProducto = T00033_A21precioProducto[0];
               Z22tipoProducto = T00033_A22tipoProducto[0];
               Z23stockSeguridad = T00033_A23stockSeguridad[0];
            }
            else
            {
               Z19descripcionProducto = A19descripcionProducto;
               Z20stockProducto = A20stockProducto;
               Z21precioProducto = A21precioProducto;
               Z22tipoProducto = A22tipoProducto;
               Z23stockSeguridad = A23stockSeguridad;
            }
         }
         if ( GX_JID == -2 )
         {
            Z3idProducto = A3idProducto;
            Z19descripcionProducto = A19descripcionProducto;
            Z20stockProducto = A20stockProducto;
            Z21precioProducto = A21precioProducto;
            Z22tipoProducto = A22tipoProducto;
            Z23stockSeguridad = A23stockSeguridad;
         }
      }

      protected void standaloneNotModal( )
      {
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

      protected void Load033( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1;
            A19descripcionProducto = T00034_A19descripcionProducto[0];
            AssignAttri("", false, "A19descripcionProducto", A19descripcionProducto);
            A20stockProducto = T00034_A20stockProducto[0];
            AssignAttri("", false, "A20stockProducto", StringUtil.LTrimStr( (decimal)(A20stockProducto), 4, 0));
            A21precioProducto = T00034_A21precioProducto[0];
            AssignAttri("", false, "A21precioProducto", StringUtil.LTrimStr( A21precioProducto, 10, 2));
            A22tipoProducto = T00034_A22tipoProducto[0];
            AssignAttri("", false, "A22tipoProducto", StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0));
            A23stockSeguridad = T00034_A23stockSeguridad[0];
            AssignAttri("", false, "A23stockSeguridad", StringUtil.LTrimStr( (decimal)(A23stockSeguridad), 4, 0));
            ZM033( -2) ;
         }
         pr_default.close(2);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         nIsDirty_3 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( ( A22tipoProducto == 0 ) || ( A22tipoProducto == 1 ) ) )
         {
            GX_msglist.addItem("Field tipo Producto is out of range", "OutOfRange", 1, "TIPOPRODUCTO");
            AnyError = 1;
            GX_FocusControl = cmbtipoProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM033( 2) ;
            RcdFound3 = 1;
            A3idProducto = T00033_A3idProducto[0];
            AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
            A19descripcionProducto = T00033_A19descripcionProducto[0];
            AssignAttri("", false, "A19descripcionProducto", A19descripcionProducto);
            A20stockProducto = T00033_A20stockProducto[0];
            AssignAttri("", false, "A20stockProducto", StringUtil.LTrimStr( (decimal)(A20stockProducto), 4, 0));
            A21precioProducto = T00033_A21precioProducto[0];
            AssignAttri("", false, "A21precioProducto", StringUtil.LTrimStr( A21precioProducto, 10, 2));
            A22tipoProducto = T00033_A22tipoProducto[0];
            AssignAttri("", false, "A22tipoProducto", StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0));
            A23stockSeguridad = T00033_A23stockSeguridad[0];
            AssignAttri("", false, "A23stockSeguridad", StringUtil.LTrimStr( (decimal)(A23stockSeguridad), 4, 0));
            Z3idProducto = A3idProducto;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode3;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
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
         RcdFound3 = 0;
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00036_A3idProducto[0] < A3idProducto ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00036_A3idProducto[0] > A3idProducto ) ) )
            {
               A3idProducto = T00036_A3idProducto[0];
               AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
               RcdFound3 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00037_A3idProducto[0] > A3idProducto ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00037_A3idProducto[0] < A3idProducto ) ) )
            {
               A3idProducto = T00037_A3idProducto[0];
               AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
               RcdFound3 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert033( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( A3idProducto != Z3idProducto )
               {
                  A3idProducto = Z3idProducto;
                  AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDPRODUCTO");
                  AnyError = 1;
                  GX_FocusControl = edtidProducto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtidProducto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtidProducto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A3idProducto != Z3idProducto )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtidProducto_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDPRODUCTO");
                     AnyError = 1;
                     GX_FocusControl = edtidProducto_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtidProducto_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert033( ) ;
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
         if ( A3idProducto != Z3idProducto )
         {
            A3idProducto = Z3idProducto;
            AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDPRODUCTO");
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtidProducto_Internalname;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "IDPRODUCTO");
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtdescripcionProducto_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdescripcionProducto_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd033( ) ;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdescripcionProducto_Internalname;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdescripcionProducto_Internalname;
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
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound3 != 0 )
            {
               ScanNext033( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtdescripcionProducto_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A3idProducto});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Producto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z19descripcionProducto, T00032_A19descripcionProducto[0]) != 0 ) || ( Z20stockProducto != T00032_A20stockProducto[0] ) || ( Z21precioProducto != T00032_A21precioProducto[0] ) || ( Z22tipoProducto != T00032_A22tipoProducto[0] ) || ( Z23stockSeguridad != T00032_A23stockSeguridad[0] ) )
            {
               if ( StringUtil.StrCmp(Z19descripcionProducto, T00032_A19descripcionProducto[0]) != 0 )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"descripcionProducto");
                  GXUtil.WriteLogRaw("Old: ",Z19descripcionProducto);
                  GXUtil.WriteLogRaw("Current: ",T00032_A19descripcionProducto[0]);
               }
               if ( Z20stockProducto != T00032_A20stockProducto[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"stockProducto");
                  GXUtil.WriteLogRaw("Old: ",Z20stockProducto);
                  GXUtil.WriteLogRaw("Current: ",T00032_A20stockProducto[0]);
               }
               if ( Z21precioProducto != T00032_A21precioProducto[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"precioProducto");
                  GXUtil.WriteLogRaw("Old: ",Z21precioProducto);
                  GXUtil.WriteLogRaw("Current: ",T00032_A21precioProducto[0]);
               }
               if ( Z22tipoProducto != T00032_A22tipoProducto[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"tipoProducto");
                  GXUtil.WriteLogRaw("Old: ",Z22tipoProducto);
                  GXUtil.WriteLogRaw("Current: ",T00032_A22tipoProducto[0]);
               }
               if ( Z23stockSeguridad != T00032_A23stockSeguridad[0] )
               {
                  GXUtil.WriteLog("producto:[seudo value changed for attri]"+"stockSeguridad");
                  GXUtil.WriteLogRaw("Old: ",Z23stockSeguridad);
                  GXUtil.WriteLogRaw("Current: ",T00032_A23stockSeguridad[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Producto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00038 */
                     pr_default.execute(6, new Object[] {A19descripcionProducto, A20stockProducto, A21precioProducto, A22tipoProducto, A23stockSeguridad});
                     A3idProducto = T00038_A3idProducto[0];
                     AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Producto") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption030( ) ;
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
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00039 */
                     pr_default.execute(7, new Object[] {A19descripcionProducto, A20stockProducto, A21precioProducto, A22tipoProducto, A23stockSeguridad, A3idProducto});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Producto") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Producto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption030( ) ;
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
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000310 */
                  pr_default.execute(8, new Object[] {A3idProducto});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Producto") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound3 == 0 )
                        {
                           InitAll033( ) ;
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
                        ResetCaption030( ) ;
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
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel033( ) ;
         Gx_mode = sMode3;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000311 */
            pr_default.execute(9, new Object[] {A3idProducto});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"id Detalle"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000312 */
            pr_default.execute(10, new Object[] {A3idProducto});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"id Detalle"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel033( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("producto",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("producto",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart033( )
      {
         /* Using cursor T000313 */
         pr_default.execute(11);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound3 = 1;
            A3idProducto = T000313_A3idProducto[0];
            AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound3 = 1;
            A3idProducto = T000313_A3idProducto[0];
            AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtidProducto_Enabled = 0;
         AssignProp("", false, edtidProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProducto_Enabled), 5, 0), true);
         edtdescripcionProducto_Enabled = 0;
         AssignProp("", false, edtdescripcionProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdescripcionProducto_Enabled), 5, 0), true);
         edtstockProducto_Enabled = 0;
         AssignProp("", false, edtstockProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtstockProducto_Enabled), 5, 0), true);
         edtprecioProducto_Enabled = 0;
         AssignProp("", false, edtprecioProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtprecioProducto_Enabled), 5, 0), true);
         cmbtipoProducto.Enabled = 0;
         AssignProp("", false, cmbtipoProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbtipoProducto.Enabled), 5, 0), true);
         edtstockSeguridad_Enabled = 0;
         AssignProp("", false, edtstockSeguridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtstockSeguridad_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes033( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
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
         context.AddJavascriptSource("gxcfg.js", "?20207161325596", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("producto.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z3idProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z19descripcionProducto", Z19descripcionProducto);
         GxWebStd.gx_hidden_field( context, "Z20stockProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20stockProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z21precioProducto", StringUtil.LTrim( StringUtil.NToC( Z21precioProducto, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z22tipoProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22tipoProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z23stockSeguridad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23stockSeguridad), 4, 0, ".", "")));
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
         return formatLink("producto.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Producto" ;
      }

      public override String GetPgmdesc( )
      {
         return "Producto" ;
      }

      protected void InitializeNonKey033( )
      {
         A19descripcionProducto = "";
         AssignAttri("", false, "A19descripcionProducto", A19descripcionProducto);
         A20stockProducto = 0;
         AssignAttri("", false, "A20stockProducto", StringUtil.LTrimStr( (decimal)(A20stockProducto), 4, 0));
         A21precioProducto = 0;
         AssignAttri("", false, "A21precioProducto", StringUtil.LTrimStr( A21precioProducto, 10, 2));
         A22tipoProducto = 0;
         AssignAttri("", false, "A22tipoProducto", StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0));
         A23stockSeguridad = 0;
         AssignAttri("", false, "A23stockSeguridad", StringUtil.LTrimStr( (decimal)(A23stockSeguridad), 4, 0));
         Z19descripcionProducto = "";
         Z20stockProducto = 0;
         Z21precioProducto = 0;
         Z22tipoProducto = 0;
         Z23stockSeguridad = 0;
      }

      protected void InitAll033( )
      {
         A3idProducto = 0;
         AssignAttri("", false, "A3idProducto", StringUtil.LTrimStr( (decimal)(A3idProducto), 4, 0));
         InitializeNonKey033( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020716132560", true, true);
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
         context.AddJavascriptSource("producto.js", "?2020716132560", false, true);
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
         edtidProducto_Internalname = "IDPRODUCTO";
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO";
         edtstockProducto_Internalname = "STOCKPRODUCTO";
         edtprecioProducto_Internalname = "PRECIOPRODUCTO";
         cmbtipoProducto_Internalname = "TIPOPRODUCTO";
         edtstockSeguridad_Internalname = "STOCKSEGURIDAD";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
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
         Form.Caption = "Producto";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtstockSeguridad_Jsonclick = "";
         edtstockSeguridad_Enabled = 1;
         cmbtipoProducto_Jsonclick = "";
         cmbtipoProducto.Enabled = 1;
         edtprecioProducto_Jsonclick = "";
         edtprecioProducto_Enabled = 1;
         edtstockProducto_Jsonclick = "";
         edtstockProducto_Enabled = 1;
         edtdescripcionProducto_Jsonclick = "";
         edtdescripcionProducto_Enabled = 1;
         edtidProducto_Jsonclick = "";
         edtidProducto_Enabled = 1;
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
         cmbtipoProducto.Name = "TIPOPRODUCTO";
         cmbtipoProducto.WebTags = "";
         cmbtipoProducto.addItem("0", "Producto de Compra", 0);
         cmbtipoProducto.addItem("1", "Producto de Venta", 0);
         if ( cmbtipoProducto.ItemCount > 0 )
         {
            A22tipoProducto = (short)(NumberUtil.Val( cmbtipoProducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0))), "."));
            AssignAttri("", false, "A22tipoProducto", StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0));
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtdescripcionProducto_Internalname;
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

      public void Valid_Idproducto( )
      {
         A22tipoProducto = (short)(NumberUtil.Val( cmbtipoProducto.CurrentValue, "."));
         cmbtipoProducto.CurrentValue = StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0);
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( cmbtipoProducto.ItemCount > 0 )
         {
            A22tipoProducto = (short)(NumberUtil.Val( cmbtipoProducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0))), "."));
            cmbtipoProducto.CurrentValue = StringUtil.LTrimStr( (decimal)(A22tipoProducto), 4, 0);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbtipoProducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0));
         }
         /*  Sending validation outputs */
         AssignAttri("", false, "A19descripcionProducto", A19descripcionProducto);
         AssignAttri("", false, "A20stockProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20stockProducto), 4, 0, ".", "")));
         AssignAttri("", false, "A21precioProducto", StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")));
         AssignAttri("", false, "A22tipoProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22tipoProducto), 4, 0, ".", "")));
         cmbtipoProducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0));
         AssignProp("", false, cmbtipoProducto_Internalname, "Values", cmbtipoProducto.ToJavascriptSource(), true);
         AssignAttri("", false, "A23stockSeguridad", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23stockSeguridad), 4, 0, ".", "")));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z3idProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z19descripcionProducto", Z19descripcionProducto);
         GxWebStd.gx_hidden_field( context, "Z20stockProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20stockProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z21precioProducto", StringUtil.LTrim( StringUtil.NToC( Z21precioProducto, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z22tipoProducto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22tipoProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z23stockSeguridad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23stockSeguridad), 4, 0, ".", "")));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
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
         setEventMetadata("VALID_IDPRODUCTO","{handler:'Valid_Idproducto',iparms:[{av:'cmbtipoProducto'},{av:'A22tipoProducto',fld:'TIPOPRODUCTO',pic:'ZZZ9'},{av:'A3idProducto',fld:'IDPRODUCTO',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_IDPRODUCTO",",oparms:[{av:'A19descripcionProducto',fld:'DESCRIPCIONPRODUCTO',pic:''},{av:'A20stockProducto',fld:'STOCKPRODUCTO',pic:'ZZZ9'},{av:'A21precioProducto',fld:'PRECIOPRODUCTO',pic:'ZZZZZZ9.99'},{av:'cmbtipoProducto'},{av:'A22tipoProducto',fld:'TIPOPRODUCTO',pic:'ZZZ9'},{av:'A23stockSeguridad',fld:'STOCKSEGURIDAD',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z3idProducto'},{av:'Z19descripcionProducto'},{av:'Z20stockProducto'},{av:'Z21precioProducto'},{av:'Z22tipoProducto'},{av:'Z23stockSeguridad'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_TIPOPRODUCTO","{handler:'Valid_Tipoproducto',iparms:[]");
         setEventMetadata("VALID_TIPOPRODUCTO",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z19descripcionProducto = "";
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
         A19descripcionProducto = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00034_A3idProducto = new short[1] ;
         T00034_A19descripcionProducto = new String[] {""} ;
         T00034_A20stockProducto = new short[1] ;
         T00034_A21precioProducto = new decimal[1] ;
         T00034_A22tipoProducto = new short[1] ;
         T00034_A23stockSeguridad = new short[1] ;
         T00035_A3idProducto = new short[1] ;
         T00033_A3idProducto = new short[1] ;
         T00033_A19descripcionProducto = new String[] {""} ;
         T00033_A20stockProducto = new short[1] ;
         T00033_A21precioProducto = new decimal[1] ;
         T00033_A22tipoProducto = new short[1] ;
         T00033_A23stockSeguridad = new short[1] ;
         sMode3 = "";
         T00036_A3idProducto = new short[1] ;
         T00037_A3idProducto = new short[1] ;
         T00032_A3idProducto = new short[1] ;
         T00032_A19descripcionProducto = new String[] {""} ;
         T00032_A20stockProducto = new short[1] ;
         T00032_A21precioProducto = new decimal[1] ;
         T00032_A22tipoProducto = new short[1] ;
         T00032_A23stockSeguridad = new short[1] ;
         T00038_A3idProducto = new short[1] ;
         T000311_A6idCompra = new short[1] ;
         T000311_A47idDetalleCompra = new short[1] ;
         T000312_A5idVenta = new short[1] ;
         T000312_A34idDetalleVenta = new short[1] ;
         T000313_A3idProducto = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ19descripcionProducto = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.producto__default(),
            new Object[][] {
                new Object[] {
               T00032_A3idProducto, T00032_A19descripcionProducto, T00032_A20stockProducto, T00032_A21precioProducto, T00032_A22tipoProducto, T00032_A23stockSeguridad
               }
               , new Object[] {
               T00033_A3idProducto, T00033_A19descripcionProducto, T00033_A20stockProducto, T00033_A21precioProducto, T00033_A22tipoProducto, T00033_A23stockSeguridad
               }
               , new Object[] {
               T00034_A3idProducto, T00034_A19descripcionProducto, T00034_A20stockProducto, T00034_A21precioProducto, T00034_A22tipoProducto, T00034_A23stockSeguridad
               }
               , new Object[] {
               T00035_A3idProducto
               }
               , new Object[] {
               T00036_A3idProducto
               }
               , new Object[] {
               T00037_A3idProducto
               }
               , new Object[] {
               T00038_A3idProducto
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000311_A6idCompra, T000311_A47idDetalleCompra
               }
               , new Object[] {
               T000312_A5idVenta, T000312_A34idDetalleVenta
               }
               , new Object[] {
               T000313_A3idProducto
               }
            }
         );
      }

      private short Z3idProducto ;
      private short Z20stockProducto ;
      private short Z22tipoProducto ;
      private short Z23stockSeguridad ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A22tipoProducto ;
      private short A3idProducto ;
      private short A20stockProducto ;
      private short A23stockSeguridad ;
      private short GX_JID ;
      private short RcdFound3 ;
      private short nIsDirty_3 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ3idProducto ;
      private short ZZ20stockProducto ;
      private short ZZ22tipoProducto ;
      private short ZZ23stockSeguridad ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtidProducto_Enabled ;
      private int edtdescripcionProducto_Enabled ;
      private int edtstockProducto_Enabled ;
      private int edtprecioProducto_Enabled ;
      private int edtstockSeguridad_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private decimal Z21precioProducto ;
      private decimal A21precioProducto ;
      private decimal ZZ21precioProducto ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtidProducto_Internalname ;
      private String cmbtipoProducto_Internalname ;
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
      private String edtidProducto_Jsonclick ;
      private String edtdescripcionProducto_Internalname ;
      private String edtdescripcionProducto_Jsonclick ;
      private String edtstockProducto_Internalname ;
      private String edtstockProducto_Jsonclick ;
      private String edtprecioProducto_Internalname ;
      private String edtprecioProducto_Jsonclick ;
      private String cmbtipoProducto_Jsonclick ;
      private String edtstockSeguridad_Internalname ;
      private String edtstockSeguridad_Jsonclick ;
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
      private String sMode3 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z19descripcionProducto ;
      private String A19descripcionProducto ;
      private String ZZ19descripcionProducto ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbtipoProducto ;
      private IDataStoreProvider pr_default ;
      private short[] T00034_A3idProducto ;
      private String[] T00034_A19descripcionProducto ;
      private short[] T00034_A20stockProducto ;
      private decimal[] T00034_A21precioProducto ;
      private short[] T00034_A22tipoProducto ;
      private short[] T00034_A23stockSeguridad ;
      private short[] T00035_A3idProducto ;
      private short[] T00033_A3idProducto ;
      private String[] T00033_A19descripcionProducto ;
      private short[] T00033_A20stockProducto ;
      private decimal[] T00033_A21precioProducto ;
      private short[] T00033_A22tipoProducto ;
      private short[] T00033_A23stockSeguridad ;
      private short[] T00036_A3idProducto ;
      private short[] T00037_A3idProducto ;
      private short[] T00032_A3idProducto ;
      private String[] T00032_A19descripcionProducto ;
      private short[] T00032_A20stockProducto ;
      private decimal[] T00032_A21precioProducto ;
      private short[] T00032_A22tipoProducto ;
      private short[] T00032_A23stockSeguridad ;
      private short[] T00038_A3idProducto ;
      private short[] T000311_A6idCompra ;
      private short[] T000311_A47idDetalleCompra ;
      private short[] T000312_A5idVenta ;
      private short[] T000312_A34idDetalleVenta ;
      private short[] T000313_A3idProducto ;
      private GXWebForm Form ;
   }

   public class producto__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@descripcionProducto",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@stockProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@precioProducto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@tipoProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockSeguridad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@descripcionProducto",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@stockProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@precioProducto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@tipoProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockSeguridad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [idProducto], [descripcionProducto], [stockProducto], [precioProducto], [tipoProducto], [stockSeguridad] FROM [Producto] WITH (UPDLOCK) WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00033", "SELECT [idProducto], [descripcionProducto], [stockProducto], [precioProducto], [tipoProducto], [stockSeguridad] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00034", "SELECT TM1.[idProducto], TM1.[descripcionProducto], TM1.[stockProducto], TM1.[precioProducto], TM1.[tipoProducto], TM1.[stockSeguridad] FROM [Producto] TM1 WHERE TM1.[idProducto] = @idProducto ORDER BY TM1.[idProducto]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00035", "SELECT [idProducto] FROM [Producto] WHERE [idProducto] = @idProducto  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00036", "SELECT TOP 1 [idProducto] FROM [Producto] WHERE ( [idProducto] > @idProducto) ORDER BY [idProducto]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00037", "SELECT TOP 1 [idProducto] FROM [Producto] WHERE ( [idProducto] < @idProducto) ORDER BY [idProducto] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00038", "INSERT INTO [Producto]([descripcionProducto], [stockProducto], [precioProducto], [tipoProducto], [stockSeguridad]) VALUES(@descripcionProducto, @stockProducto, @precioProducto, @tipoProducto, @stockSeguridad); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00038)
             ,new CursorDef("T00039", "UPDATE [Producto] SET [descripcionProducto]=@descripcionProducto, [stockProducto]=@stockProducto, [precioProducto]=@precioProducto, [tipoProducto]=@tipoProducto, [stockSeguridad]=@stockSeguridad  WHERE [idProducto] = @idProducto", GxErrorMask.GX_NOMASK,prmT00039)
             ,new CursorDef("T000310", "DELETE FROM [Producto]  WHERE [idProducto] = @idProducto", GxErrorMask.GX_NOMASK,prmT000310)
             ,new CursorDef("T000311", "SELECT TOP 1 [idCompra], [idDetalleCompra] FROM [CompraidDetalle] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000311,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000312", "SELECT TOP 1 [idVenta], [idDetalleVenta] FROM [VentaidDetalle] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000312,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000313", "SELECT [idProducto] FROM [Producto] ORDER BY [idProducto]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 11 :
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
