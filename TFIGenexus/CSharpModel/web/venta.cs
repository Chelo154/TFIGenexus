/*
               File: Venta
        Description: Venta
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:12:8.66
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
   public class venta : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A5idVenta = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_9( A5idVenta) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A1idCliente = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_8( A1idCliente) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A3idProducto = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A3idProducto) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridventa_iddetalle") == 0 )
         {
            nRC_GXsfl_78 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_78_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_78_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridventa_iddetalle_newrow( ) ;
            return  ;
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
            Form.Meta.addItem("description", "Venta", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtidVenta_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public venta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public venta( IGxContext context )
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
         cmbtipoFacturaVenta = new GXCombobox();
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
         if ( cmbtipoFacturaVenta.ItemCount > 0 )
         {
            A37tipoFacturaVenta = (short)(NumberUtil.Val( cmbtipoFacturaVenta.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0))), "."));
            AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbtipoFacturaVenta.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0));
            AssignProp("", false, cmbtipoFacturaVenta_Internalname, "Values", cmbtipoFacturaVenta.ToJavascriptSource(), true);
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Venta", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Venta.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDVENTA"+"'), id:'"+"IDVENTA"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Venta.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidVenta_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidVenta_Internalname, "Venta", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5idVenta), 4, 0, ".", "")), ((edtidVenta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5idVenta), "ZZZ9")) : context.localUtil.Format( (decimal)(A5idVenta), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidVenta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidVenta_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbtipoFacturaVenta_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, cmbtipoFacturaVenta_Internalname, "Factura Venta", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         /* ComboBox */
         GxWebStd.gx_combobox_ctrl1( context, cmbtipoFacturaVenta, cmbtipoFacturaVenta_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0)), 1, cmbtipoFacturaVenta_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbtipoFacturaVenta.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "", true, "HLP_Venta.htm");
         cmbtipoFacturaVenta.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0));
         AssignProp("", false, cmbtipoFacturaVenta_Internalname, "Values", (String)(cmbtipoFacturaVenta.ToJavascriptSource()), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtfechaVenta_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtfechaVenta_Internalname, "Venta", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtfechaVenta_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtfechaVenta_Internalname, context.localUtil.Format(A30fechaVenta, "99/99/99"), context.localUtil.Format( A30fechaVenta, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtfechaVenta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtfechaVenta_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_bitmap( context, edtfechaVenta_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtfechaVenta_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Venta.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtporcentajeIVA_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtporcentajeIVA_Internalname, "IVA", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtporcentajeIVA_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31porcentajeIVA), 10, 0, ".", "")), ((edtporcentajeIVA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A31porcentajeIVA), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A31porcentajeIVA), "ZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtporcentajeIVA_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtporcentajeIVA_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttotalNetoVenta_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttotalNetoVenta_Internalname, "Neto Venta", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edttotalNetoVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( A39totalNetoVenta, 10, 2, ".", "")), ((edttotalNetoVenta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A39totalNetoVenta, "ZZZZZZ9.99")) : context.localUtil.Format( A39totalNetoVenta, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttotalNetoVenta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttotalNetoVenta_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "Precio", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttotalAPagarVenta_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttotalAPagarVenta_Internalname, "APagar Venta", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edttotalAPagarVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( A40totalAPagarVenta, 10, 2, ".", "")), ((edttotalAPagarVenta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A40totalAPagarVenta, "ZZZZZZ9.99")) : context.localUtil.Format( A40totalAPagarVenta, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttotalAPagarVenta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttotalAPagarVenta_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "Precio", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidCliente_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidCliente_Internalname, "id Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidCliente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1idCliente), 4, 0, ".", "")), ((edtidCliente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1idCliente), "ZZZ9")) : context.localUtil.Format( (decimal)(A1idCliente), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidCliente_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
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
         GxWebStd.gx_label_element( context, edtnombreCliente_Internalname, "nombre Cliente", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtnombreCliente_Internalname, A9nombreCliente, StringUtil.RTrim( context.localUtil.Format( A9nombreCliente, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreCliente_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreCliente_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divIddetalletable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitleiddetalle_Internalname, "id Detalle", "", "", lblTitleiddetalle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridventa_iddetalle( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridventa_iddetalle( )
      {
         /*  Grid Control  */
         Gridventa_iddetalleContainer.AddObjectProperty("GridName", "Gridventa_iddetalle");
         Gridventa_iddetalleContainer.AddObjectProperty("Header", subGridventa_iddetalle_Header);
         Gridventa_iddetalleContainer.AddObjectProperty("Class", "Grid");
         Gridventa_iddetalleContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Backcolorstyle), 1, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("CmpContext", "");
         Gridventa_iddetalleContainer.AddObjectProperty("InMasterPage", "false");
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34idDetalleVenta), 4, 0, ".", "")));
         Gridventa_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleVenta_Enabled), 5, 0, ".", "")));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")));
         Gridventa_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", "")));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleColumn.AddObjectProperty("Value", A19descripcionProducto);
         Gridventa_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", "")));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")));
         Gridventa_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", "")));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A41cantidadDetalleVenta), 4, 0, ".", "")));
         Gridventa_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleVenta_Enabled), 5, 0, ".", "")));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridventa_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A42subtotalDetalleVenta, 10, 2, ".", "")));
         Gridventa_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleVenta_Enabled), 5, 0, ".", "")));
         Gridventa_iddetalleContainer.AddColumnProperties(Gridventa_iddetalleColumn);
         Gridventa_iddetalleContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Selectedindex), 4, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Allowselection), 1, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Selectioncolor), 9, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Allowhovering), 1, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Hoveringcolor), 9, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Allowcollapsing), 1, 0, ".", "")));
         Gridventa_iddetalleContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridventa_iddetalle_Collapsed), 1, 0, ".", "")));
         nGXsfl_78_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount10 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_10 = 1;
               ScanStart0510( ) ;
               while ( RcdFound10 != 0 )
               {
                  init_level_properties10( ) ;
                  getByPrimaryKey0510( ) ;
                  AddRow0510( ) ;
                  ScanNext0510( ) ;
               }
               ScanEnd0510( ) ;
               nBlankRcdCount10 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B39totalNetoVenta = A39totalNetoVenta;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            standaloneNotModal0510( ) ;
            standaloneModal0510( ) ;
            sMode10 = Gx_mode;
            while ( nGXsfl_78_idx < nRC_GXsfl_78 )
            {
               bGXsfl_78_Refreshing = true;
               ReadRow0510( ) ;
               edtidDetalleVenta_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDDETALLEVENTA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtidDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtidProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtidProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtdescripcionProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtdescripcionProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdescripcionProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtprecioProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtprecioProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtprecioProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtcantidadDetalleVenta_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDADDETALLEVENTA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtcantidadDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtcantidadDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtsubtotalDetalleVenta_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBTOTALDETALLEVENTA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtsubtotalDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtsubtotalDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_3_"+sGXsfl_78_idx+"Link");
               if ( ( nRcdExists_10 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0510( ) ;
               }
               SendRow0510( ) ;
               bGXsfl_78_Refreshing = false;
            }
            Gx_mode = sMode10;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            A39totalNetoVenta = B39totalNetoVenta;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount10 = 5;
            nRcdExists_10 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart0510( ) ;
               while ( RcdFound10 != 0 )
               {
                  sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_7810( ) ;
                  init_level_properties10( ) ;
                  standaloneNotModal0510( ) ;
                  getByPrimaryKey0510( ) ;
                  standaloneModal0510( ) ;
                  AddRow0510( ) ;
                  ScanNext0510( ) ;
               }
               ScanEnd0510( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode10 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx+1), 4, 0), 4, "0");
         SubsflControlProps_7810( ) ;
         InitAll0510( ) ;
         init_level_properties10( ) ;
         B39totalNetoVenta = A39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         nRcdExists_10 = 0;
         nIsMod_10 = 0;
         nRcdDeleted_10 = 0;
         nBlankRcdCount10 = (short)(nBlankRcdUsr10+nBlankRcdCount10);
         fRowAdded = 0;
         while ( nBlankRcdCount10 > 0 )
         {
            standaloneNotModal0510( ) ;
            standaloneModal0510( ) ;
            AddRow0510( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtidDetalleVenta_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount10 = (short)(nBlankRcdCount10-1);
         }
         Gx_mode = sMode10;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         A39totalNetoVenta = B39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridventa_iddetalleContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridventa_iddetalle", Gridventa_iddetalleContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridventa_iddetalleContainerData", Gridventa_iddetalleContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridventa_iddetalleContainerData"+"V", Gridventa_iddetalleContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridventa_iddetalleContainerData"+"V"+"\" value='"+Gridventa_iddetalleContainer.GridValuesHidden()+"'/>") ;
         }
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
            Z5idVenta = (short)(context.localUtil.CToN( cgiGet( "Z5idVenta"), ".", ","));
            Z37tipoFacturaVenta = (short)(context.localUtil.CToN( cgiGet( "Z37tipoFacturaVenta"), ".", ","));
            Z30fechaVenta = context.localUtil.CToD( cgiGet( "Z30fechaVenta"), 0);
            Z31porcentajeIVA = (long)(context.localUtil.CToN( cgiGet( "Z31porcentajeIVA"), ".", ","));
            Z1idCliente = (short)(context.localUtil.CToN( cgiGet( "Z1idCliente"), ".", ","));
            O39totalNetoVenta = context.localUtil.CToN( cgiGet( "O39totalNetoVenta"), ".", ",");
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            nRC_GXsfl_78 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_78"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtidVenta_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidVenta_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDVENTA");
               AnyError = 1;
               GX_FocusControl = edtidVenta_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A5idVenta = 0;
               AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
            }
            else
            {
               A5idVenta = (short)(context.localUtil.CToN( cgiGet( edtidVenta_Internalname), ".", ","));
               AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
            }
            cmbtipoFacturaVenta.Name = cmbtipoFacturaVenta_Internalname;
            cmbtipoFacturaVenta.CurrentValue = cgiGet( cmbtipoFacturaVenta_Internalname);
            A37tipoFacturaVenta = (short)(NumberUtil.Val( cgiGet( cmbtipoFacturaVenta_Internalname), "."));
            AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0));
            if ( context.localUtil.VCDate( cgiGet( edtfechaVenta_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fecha Venta"}), 1, "FECHAVENTA");
               AnyError = 1;
               GX_FocusControl = edtfechaVenta_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A30fechaVenta = DateTime.MinValue;
               AssignAttri("", false, "A30fechaVenta", context.localUtil.Format(A30fechaVenta, "99/99/99"));
            }
            else
            {
               A30fechaVenta = context.localUtil.CToD( cgiGet( edtfechaVenta_Internalname), 1);
               AssignAttri("", false, "A30fechaVenta", context.localUtil.Format(A30fechaVenta, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtporcentajeIVA_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtporcentajeIVA_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PORCENTAJEIVA");
               AnyError = 1;
               GX_FocusControl = edtporcentajeIVA_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A31porcentajeIVA = 0;
               AssignAttri("", false, "A31porcentajeIVA", StringUtil.LTrimStr( (decimal)(A31porcentajeIVA), 10, 0));
            }
            else
            {
               A31porcentajeIVA = (long)(context.localUtil.CToN( cgiGet( edtporcentajeIVA_Internalname), ".", ","));
               AssignAttri("", false, "A31porcentajeIVA", StringUtil.LTrimStr( (decimal)(A31porcentajeIVA), 10, 0));
            }
            A39totalNetoVenta = context.localUtil.CToN( cgiGet( edttotalNetoVenta_Internalname), ".", ",");
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            A40totalAPagarVenta = context.localUtil.CToN( cgiGet( edttotalAPagarVenta_Internalname), ".", ",");
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
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
            A9nombreCliente = cgiGet( edtnombreCliente_Internalname);
            AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            standaloneNotModal( ) ;
         }
         else
         {
            standaloneNotModal( ) ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
            {
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               A5idVenta = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
               InitAll055( ) ;
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
         DisableAttributes055( ) ;
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

      protected void CONFIRM_0510( )
      {
         s39totalNetoVenta = O39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         s40totalAPagarVenta = O40totalAPagarVenta;
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         nGXsfl_78_idx = 0;
         while ( nGXsfl_78_idx < nRC_GXsfl_78 )
         {
            ReadRow0510( ) ;
            if ( ( nRcdExists_10 != 0 ) || ( nIsMod_10 != 0 ) )
            {
               GetKey0510( ) ;
               if ( ( nRcdExists_10 == 0 ) && ( nRcdDeleted_10 == 0 ) )
               {
                  if ( RcdFound10 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0510( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0510( ) ;
                        CloseExtendedTableCursors0510( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                        O39totalNetoVenta = A39totalNetoVenta;
                        n39totalNetoVenta = false;
                        AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                        O40totalAPagarVenta = A40totalAPagarVenta;
                        AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                     }
                  }
                  else
                  {
                     GXCCtl = "IDDETALLEVENTA_" + sGXsfl_78_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtidDetalleVenta_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound10 != 0 )
                  {
                     if ( nRcdDeleted_10 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0510( ) ;
                        Load0510( ) ;
                        BeforeValidate0510( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0510( ) ;
                           O39totalNetoVenta = A39totalNetoVenta;
                           n39totalNetoVenta = false;
                           AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                           O40totalAPagarVenta = A40totalAPagarVenta;
                           AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                        }
                     }
                     else
                     {
                        if ( nIsMod_10 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0510( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0510( ) ;
                              CloseExtendedTableCursors0510( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                              O39totalNetoVenta = A39totalNetoVenta;
                              n39totalNetoVenta = false;
                              AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                              O40totalAPagarVenta = A40totalAPagarVenta;
                              AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_10 == 0 )
                     {
                        GXCCtl = "IDDETALLEVENTA_" + sGXsfl_78_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtidDetalleVenta_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtidDetalleVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34idDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( edtidProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( edtdescripcionProducto_Internalname, A19descripcionProducto) ;
            ChangePostValue( edtprecioProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", ""))) ;
            ChangePostValue( edtcantidadDetalleVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A41cantidadDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( edtsubtotalDetalleVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( A42subtotalDetalleVenta, 10, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z34idDetalleVenta_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34idDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z41cantidadDetalleVenta_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41cantidadDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( "T42subtotalDetalleVenta_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( O42subtotalDetalleVenta, 10, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_10_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_10), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_10_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_10), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_10_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_10), 4, 0, ".", ""))) ;
            if ( nIsMod_10 != 0 )
            {
               ChangePostValue( "IDDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleVenta_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDADDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleVenta_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBTOTALDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleVenta_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O39totalNetoVenta = s39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         O40totalAPagarVenta = s40totalAPagarVenta;
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption050( )
      {
      }

      protected void ZM055( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z37tipoFacturaVenta = T00056_A37tipoFacturaVenta[0];
               Z30fechaVenta = T00056_A30fechaVenta[0];
               Z31porcentajeIVA = T00056_A31porcentajeIVA[0];
               Z1idCliente = T00056_A1idCliente[0];
            }
            else
            {
               Z37tipoFacturaVenta = A37tipoFacturaVenta;
               Z30fechaVenta = A30fechaVenta;
               Z31porcentajeIVA = A31porcentajeIVA;
               Z1idCliente = A1idCliente;
            }
         }
         if ( GX_JID == -7 )
         {
            Z5idVenta = A5idVenta;
            Z37tipoFacturaVenta = A37tipoFacturaVenta;
            Z30fechaVenta = A30fechaVenta;
            Z31porcentajeIVA = A31porcentajeIVA;
            Z1idCliente = A1idCliente;
            Z39totalNetoVenta = A39totalNetoVenta;
            Z9nombreCliente = A9nombreCliente;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDCLIENTE"+"'), id:'"+"IDCLIENTE"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load055( )
      {
         /* Using cursor T000511 */
         pr_default.execute(7, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound5 = 1;
            A37tipoFacturaVenta = T000511_A37tipoFacturaVenta[0];
            AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0));
            A30fechaVenta = T000511_A30fechaVenta[0];
            AssignAttri("", false, "A30fechaVenta", context.localUtil.Format(A30fechaVenta, "99/99/99"));
            A31porcentajeIVA = T000511_A31porcentajeIVA[0];
            AssignAttri("", false, "A31porcentajeIVA", StringUtil.LTrimStr( (decimal)(A31porcentajeIVA), 10, 0));
            A9nombreCliente = T000511_A9nombreCliente[0];
            AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
            A1idCliente = T000511_A1idCliente[0];
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            A39totalNetoVenta = T000511_A39totalNetoVenta[0];
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            n39totalNetoVenta = T000511_n39totalNetoVenta[0];
            ZM055( -7) ;
         }
         pr_default.close(7);
         OnLoadActions055( ) ;
      }

      protected void OnLoadActions055( )
      {
         O39totalNetoVenta = A39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         A40totalAPagarVenta = (decimal)(A39totalNetoVenta+(A39totalNetoVenta*A31porcentajeIVA)/ (decimal)(100));
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
      }

      protected void CheckExtendedTable055( )
      {
         nIsDirty_5 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00059 */
         pr_default.execute(6, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(6) != 101) )
         {
            A39totalNetoVenta = T00059_A39totalNetoVenta[0];
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            n39totalNetoVenta = T00059_n39totalNetoVenta[0];
         }
         else
         {
            nIsDirty_5 = 1;
            A39totalNetoVenta = 0;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         }
         pr_default.close(6);
         nIsDirty_5 = 1;
         A40totalAPagarVenta = (decimal)(A39totalNetoVenta+(A39totalNetoVenta*A31porcentajeIVA)/ (decimal)(100));
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         if ( ! ( ( A37tipoFacturaVenta == 0 ) || ( A37tipoFacturaVenta == 1 ) || ( A37tipoFacturaVenta == 2 ) ) )
         {
            GX_msglist.addItem("Field tipo Factura Venta is out of range", "OutOfRange", 1, "TIPOFACTURAVENTA");
            AnyError = 1;
            GX_FocusControl = cmbtipoFacturaVenta_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A30fechaVenta) || ( A30fechaVenta >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field fecha Venta is out of range", "OutOfRange", 1, "FECHAVENTA");
            AnyError = 1;
            GX_FocusControl = edtfechaVenta_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Cliente'.", "ForeignKeyNotFound", 1, "IDCLIENTE");
            AnyError = 1;
            GX_FocusControl = edtidCliente_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9nombreCliente = T00057_A9nombreCliente[0];
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors055( )
      {
         pr_default.close(6);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_9( short A5idVenta )
      {
         /* Using cursor T000513 */
         pr_default.execute(8, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A39totalNetoVenta = T000513_A39totalNetoVenta[0];
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            n39totalNetoVenta = T000513_n39totalNetoVenta[0];
         }
         else
         {
            A39totalNetoVenta = 0;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A39totalNetoVenta, 10, 2, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(8) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(8);
      }

      protected void gxLoad_8( short A1idCliente )
      {
         /* Using cursor T000514 */
         pr_default.execute(9, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Cliente'.", "ForeignKeyNotFound", 1, "IDCLIENTE");
            AnyError = 1;
            GX_FocusControl = edtidCliente_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9nombreCliente = T000514_A9nombreCliente[0];
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A9nombreCliente)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(9) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(9);
      }

      protected void GetKey055( )
      {
         /* Using cursor T000515 */
         pr_default.execute(10, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM055( 7) ;
            RcdFound5 = 1;
            A5idVenta = T00056_A5idVenta[0];
            AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
            A37tipoFacturaVenta = T00056_A37tipoFacturaVenta[0];
            AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0));
            A30fechaVenta = T00056_A30fechaVenta[0];
            AssignAttri("", false, "A30fechaVenta", context.localUtil.Format(A30fechaVenta, "99/99/99"));
            A31porcentajeIVA = T00056_A31porcentajeIVA[0];
            AssignAttri("", false, "A31porcentajeIVA", StringUtil.LTrimStr( (decimal)(A31porcentajeIVA), 10, 0));
            A1idCliente = T00056_A1idCliente[0];
            AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
            Z5idVenta = A5idVenta;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load055( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey055( ) ;
            }
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey055( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey055( ) ;
         if ( RcdFound5 == 0 )
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
         RcdFound5 = 0;
         /* Using cursor T000516 */
         pr_default.execute(11, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000516_A5idVenta[0] < A5idVenta ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000516_A5idVenta[0] > A5idVenta ) ) )
            {
               A5idVenta = T000516_A5idVenta[0];
               AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T000517 */
         pr_default.execute(12, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000517_A5idVenta[0] > A5idVenta ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000517_A5idVenta[0] < A5idVenta ) ) )
            {
               A5idVenta = T000517_A5idVenta[0];
               AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey055( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            A39totalNetoVenta = O39totalNetoVenta;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            A40totalAPagarVenta = O40totalAPagarVenta;
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
            GX_FocusControl = edtidVenta_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert055( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A5idVenta != Z5idVenta )
               {
                  A5idVenta = Z5idVenta;
                  AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDVENTA");
                  AnyError = 1;
                  GX_FocusControl = edtidVenta_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  A39totalNetoVenta = O39totalNetoVenta;
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                  A40totalAPagarVenta = O40totalAPagarVenta;
                  AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtidVenta_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  A39totalNetoVenta = O39totalNetoVenta;
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                  A40totalAPagarVenta = O40totalAPagarVenta;
                  AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                  Update055( ) ;
                  GX_FocusControl = edtidVenta_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A5idVenta != Z5idVenta )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  A39totalNetoVenta = O39totalNetoVenta;
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                  A40totalAPagarVenta = O40totalAPagarVenta;
                  AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                  GX_FocusControl = edtidVenta_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert055( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDVENTA");
                     AnyError = 1;
                     GX_FocusControl = edtidVenta_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     A39totalNetoVenta = O39totalNetoVenta;
                     n39totalNetoVenta = false;
                     AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                     A40totalAPagarVenta = O40totalAPagarVenta;
                     AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                     GX_FocusControl = edtidVenta_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert055( ) ;
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
         if ( A5idVenta != Z5idVenta )
         {
            A5idVenta = Z5idVenta;
            AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDVENTA");
            AnyError = 1;
            GX_FocusControl = edtidVenta_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A39totalNetoVenta = O39totalNetoVenta;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            A40totalAPagarVenta = O40totalAPagarVenta;
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtidVenta_Internalname;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "IDVENTA");
            AnyError = 1;
            GX_FocusControl = edtidVenta_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = cmbtipoFacturaVenta_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaVenta_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd055( ) ;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaVenta_Internalname;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaVenta_Internalname;
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
         ScanStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext055( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaVenta_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd055( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency055( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00055 */
            pr_default.execute(3, new Object[] {A5idVenta});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Venta"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z37tipoFacturaVenta != T00055_A37tipoFacturaVenta[0] ) || ( Z30fechaVenta != T00055_A30fechaVenta[0] ) || ( Z31porcentajeIVA != T00055_A31porcentajeIVA[0] ) || ( Z1idCliente != T00055_A1idCliente[0] ) )
            {
               if ( Z37tipoFacturaVenta != T00055_A37tipoFacturaVenta[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"tipoFacturaVenta");
                  GXUtil.WriteLogRaw("Old: ",Z37tipoFacturaVenta);
                  GXUtil.WriteLogRaw("Current: ",T00055_A37tipoFacturaVenta[0]);
               }
               if ( Z30fechaVenta != T00055_A30fechaVenta[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"fechaVenta");
                  GXUtil.WriteLogRaw("Old: ",Z30fechaVenta);
                  GXUtil.WriteLogRaw("Current: ",T00055_A30fechaVenta[0]);
               }
               if ( Z31porcentajeIVA != T00055_A31porcentajeIVA[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"porcentajeIVA");
                  GXUtil.WriteLogRaw("Old: ",Z31porcentajeIVA);
                  GXUtil.WriteLogRaw("Current: ",T00055_A31porcentajeIVA[0]);
               }
               if ( Z1idCliente != T00055_A1idCliente[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"idCliente");
                  GXUtil.WriteLogRaw("Old: ",Z1idCliente);
                  GXUtil.WriteLogRaw("Current: ",T00055_A1idCliente[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Venta"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM055( 0) ;
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000518 */
                     pr_default.execute(13, new Object[] {A5idVenta, A37tipoFacturaVenta, A30fechaVenta, A31porcentajeIVA, A1idCliente});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( (pr_default.getStatus(13) == 1) )
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
                           ProcessLevel055( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption050( ) ;
                           }
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
               Load055( ) ;
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void Update055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000519 */
                     pr_default.execute(14, new Object[] {A37tipoFacturaVenta, A30fechaVenta, A31porcentajeIVA, A1idCliente, A5idVenta});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Venta"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate055( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel055( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption050( ) ;
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
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void DeferredUpdate055( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls055( ) ;
            AfterConfirm055( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete055( ) ;
               if ( AnyError == 0 )
               {
                  A39totalNetoVenta = O39totalNetoVenta;
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                  A40totalAPagarVenta = O40totalAPagarVenta;
                  AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                  ScanStart0510( ) ;
                  while ( RcdFound10 != 0 )
                  {
                     getByPrimaryKey0510( ) ;
                     Delete0510( ) ;
                     ScanNext0510( ) ;
                     O39totalNetoVenta = A39totalNetoVenta;
                     n39totalNetoVenta = false;
                     AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                     O40totalAPagarVenta = A40totalAPagarVenta;
                     AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
                  }
                  ScanEnd0510( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000520 */
                     pr_default.execute(15, new Object[] {A5idVenta});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound5 == 0 )
                           {
                              InitAll055( ) ;
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
                           ResetCaption050( ) ;
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
         }
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel055( ) ;
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls055( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000522 */
            pr_default.execute(16, new Object[] {A5idVenta});
            if ( (pr_default.getStatus(16) != 101) )
            {
               A39totalNetoVenta = T000522_A39totalNetoVenta[0];
               AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
               n39totalNetoVenta = T000522_n39totalNetoVenta[0];
            }
            else
            {
               A39totalNetoVenta = 0;
               n39totalNetoVenta = false;
               AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            }
            pr_default.close(16);
            A40totalAPagarVenta = (decimal)(A39totalNetoVenta+(A39totalNetoVenta*A31porcentajeIVA)/ (decimal)(100));
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
            /* Using cursor T000523 */
            pr_default.execute(17, new Object[] {A1idCliente});
            A9nombreCliente = T000523_A9nombreCliente[0];
            AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
            pr_default.close(17);
         }
      }

      protected void ProcessNestedLevel0510( )
      {
         s39totalNetoVenta = O39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         s40totalAPagarVenta = O40totalAPagarVenta;
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         nGXsfl_78_idx = 0;
         while ( nGXsfl_78_idx < nRC_GXsfl_78 )
         {
            ReadRow0510( ) ;
            if ( ( nRcdExists_10 != 0 ) || ( nIsMod_10 != 0 ) )
            {
               standaloneNotModal0510( ) ;
               GetKey0510( ) ;
               if ( ( nRcdExists_10 == 0 ) && ( nRcdDeleted_10 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert0510( ) ;
               }
               else
               {
                  if ( RcdFound10 != 0 )
                  {
                     if ( ( nRcdDeleted_10 != 0 ) && ( nRcdExists_10 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete0510( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_10 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update0510( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_10 == 0 )
                     {
                        GXCCtl = "IDDETALLEVENTA_" + sGXsfl_78_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtidDetalleVenta_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O39totalNetoVenta = A39totalNetoVenta;
               n39totalNetoVenta = false;
               AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
               O40totalAPagarVenta = A40totalAPagarVenta;
               AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
            }
            ChangePostValue( edtidDetalleVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34idDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( edtidProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( edtdescripcionProducto_Internalname, A19descripcionProducto) ;
            ChangePostValue( edtprecioProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", ""))) ;
            ChangePostValue( edtcantidadDetalleVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A41cantidadDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( edtsubtotalDetalleVenta_Internalname, StringUtil.LTrim( StringUtil.NToC( A42subtotalDetalleVenta, 10, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z34idDetalleVenta_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34idDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z41cantidadDetalleVenta_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41cantidadDetalleVenta), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( "T42subtotalDetalleVenta_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( O42subtotalDetalleVenta, 10, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_10_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_10), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_10_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_10), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_10_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_10), 4, 0, ".", ""))) ;
            if ( nIsMod_10 != 0 )
            {
               ChangePostValue( "IDDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleVenta_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDADDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleVenta_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBTOTALDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleVenta_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0510( ) ;
         if ( AnyError != 0 )
         {
            O39totalNetoVenta = s39totalNetoVenta;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            O40totalAPagarVenta = s40totalAPagarVenta;
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         }
         nRcdExists_10 = 0;
         nIsMod_10 = 0;
         nRcdDeleted_10 = 0;
      }

      protected void ProcessLevel055( )
      {
         /* Save parent mode. */
         sMode5 = Gx_mode;
         ProcessNestedLevel0510( ) ;
         if ( AnyError != 0 )
         {
            O39totalNetoVenta = s39totalNetoVenta;
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            O40totalAPagarVenta = s40totalAPagarVenta;
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         }
         /* Restore parent mode. */
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel055( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete055( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(16);
            pr_default.close(2);
            context.CommitDataStores("venta",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(16);
            pr_default.close(2);
            context.RollbackDataStores("venta",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart055( )
      {
         /* Using cursor T000524 */
         pr_default.execute(18);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound5 = 1;
            A5idVenta = T000524_A5idVenta[0];
            AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext055( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound5 = 1;
            A5idVenta = T000524_A5idVenta[0];
            AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
         }
      }

      protected void ScanEnd055( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm055( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert055( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate055( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete055( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete055( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate055( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes055( )
      {
         edtidVenta_Enabled = 0;
         AssignProp("", false, edtidVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidVenta_Enabled), 5, 0), true);
         cmbtipoFacturaVenta.Enabled = 0;
         AssignProp("", false, cmbtipoFacturaVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbtipoFacturaVenta.Enabled), 5, 0), true);
         edtfechaVenta_Enabled = 0;
         AssignProp("", false, edtfechaVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtfechaVenta_Enabled), 5, 0), true);
         edtporcentajeIVA_Enabled = 0;
         AssignProp("", false, edtporcentajeIVA_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtporcentajeIVA_Enabled), 5, 0), true);
         edttotalNetoVenta_Enabled = 0;
         AssignProp("", false, edttotalNetoVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttotalNetoVenta_Enabled), 5, 0), true);
         edttotalAPagarVenta_Enabled = 0;
         AssignProp("", false, edttotalAPagarVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttotalAPagarVenta_Enabled), 5, 0), true);
         edtidCliente_Enabled = 0;
         AssignProp("", false, edtidCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidCliente_Enabled), 5, 0), true);
         edtnombreCliente_Enabled = 0;
         AssignProp("", false, edtnombreCliente_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreCliente_Enabled), 5, 0), true);
      }

      protected void ZM0510( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z41cantidadDetalleVenta = T00053_A41cantidadDetalleVenta[0];
               Z3idProducto = T00053_A3idProducto[0];
            }
            else
            {
               Z41cantidadDetalleVenta = A41cantidadDetalleVenta;
               Z3idProducto = A3idProducto;
            }
         }
         if ( GX_JID == -10 )
         {
            Z5idVenta = A5idVenta;
            Z34idDetalleVenta = A34idDetalleVenta;
            Z41cantidadDetalleVenta = A41cantidadDetalleVenta;
            Z3idProducto = A3idProducto;
            Z19descripcionProducto = A19descripcionProducto;
            Z21precioProducto = A21precioProducto;
         }
      }

      protected void standaloneNotModal0510( )
      {
      }

      protected void standaloneModal0510( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtidDetalleVenta_Enabled = 0;
            AssignProp("", false, edtidDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         }
         else
         {
            edtidDetalleVenta_Enabled = 1;
            AssignProp("", false, edtidDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         }
      }

      protected void Load0510( )
      {
         /* Using cursor T000525 */
         pr_default.execute(19, new Object[] {A5idVenta, A34idDetalleVenta});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound10 = 1;
            A19descripcionProducto = T000525_A19descripcionProducto[0];
            A21precioProducto = T000525_A21precioProducto[0];
            A41cantidadDetalleVenta = T000525_A41cantidadDetalleVenta[0];
            A3idProducto = T000525_A3idProducto[0];
            ZM0510( -10) ;
         }
         pr_default.close(19);
         OnLoadActions0510( ) ;
      }

      protected void OnLoadActions0510( )
      {
         A42subtotalDetalleVenta = (decimal)(A21precioProducto*A41cantidadDetalleVenta);
         O42subtotalDetalleVenta = A42subtotalDetalleVenta;
         if ( IsIns( )  )
         {
            A39totalNetoVenta = (decimal)(O39totalNetoVenta+A42subtotalDetalleVenta);
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         }
         else
         {
            if ( IsUpd( )  )
            {
               A39totalNetoVenta = (decimal)(O39totalNetoVenta+A42subtotalDetalleVenta-O42subtotalDetalleVenta);
               n39totalNetoVenta = false;
               AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            }
            else
            {
               if ( IsDlt( )  )
               {
                  A39totalNetoVenta = (decimal)(O39totalNetoVenta-O42subtotalDetalleVenta);
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
               }
            }
         }
         A40totalAPagarVenta = (decimal)(A39totalNetoVenta+(A39totalNetoVenta*A31porcentajeIVA)/ (decimal)(100));
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
      }

      protected void CheckExtendedTable0510( )
      {
         nIsDirty_10 = 0;
         Gx_BScreen = 1;
         standaloneModal0510( ) ;
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "IDPRODUCTO_" + sGXsfl_78_idx;
            GX_msglist.addItem("No matching 'Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A19descripcionProducto = T00054_A19descripcionProducto[0];
         A21precioProducto = T00054_A21precioProducto[0];
         pr_default.close(2);
         nIsDirty_10 = 1;
         A42subtotalDetalleVenta = (decimal)(A21precioProducto*A41cantidadDetalleVenta);
         if ( IsIns( )  )
         {
            nIsDirty_10 = 1;
            A39totalNetoVenta = (decimal)(O39totalNetoVenta+A42subtotalDetalleVenta);
            n39totalNetoVenta = false;
            AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         }
         else
         {
            if ( IsUpd( )  )
            {
               nIsDirty_10 = 1;
               A39totalNetoVenta = (decimal)(O39totalNetoVenta+A42subtotalDetalleVenta-O42subtotalDetalleVenta);
               n39totalNetoVenta = false;
               AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            }
            else
            {
               if ( IsDlt( )  )
               {
                  nIsDirty_10 = 1;
                  A39totalNetoVenta = (decimal)(O39totalNetoVenta-O42subtotalDetalleVenta);
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
               }
            }
         }
         nIsDirty_10 = 1;
         A40totalAPagarVenta = (decimal)(A39totalNetoVenta+(A39totalNetoVenta*A31porcentajeIVA)/ (decimal)(100));
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
      }

      protected void CloseExtendedTableCursors0510( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0510( )
      {
      }

      protected void gxLoad_11( short A3idProducto )
      {
         /* Using cursor T000526 */
         pr_default.execute(20, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GXCCtl = "IDPRODUCTO_" + sGXsfl_78_idx;
            GX_msglist.addItem("No matching 'Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A19descripcionProducto = T000526_A19descripcionProducto[0];
         A21precioProducto = T000526_A21precioProducto[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A19descripcionProducto)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(20) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(20);
      }

      protected void GetKey0510( )
      {
         /* Using cursor T000527 */
         pr_default.execute(21, new Object[] {A5idVenta, A34idDetalleVenta});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey0510( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A5idVenta, A34idDetalleVenta});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0510( 10) ;
            RcdFound10 = 1;
            InitializeNonKey0510( ) ;
            A34idDetalleVenta = T00053_A34idDetalleVenta[0];
            A41cantidadDetalleVenta = T00053_A41cantidadDetalleVenta[0];
            A3idProducto = T00053_A3idProducto[0];
            Z5idVenta = A5idVenta;
            Z34idDetalleVenta = A34idDetalleVenta;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0510( ) ;
            Load0510( ) ;
            Gx_mode = sMode10;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0510( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0510( ) ;
            Gx_mode = sMode10;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes0510( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0510( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A5idVenta, A34idDetalleVenta});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VentaidDetalle"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z41cantidadDetalleVenta != T00052_A41cantidadDetalleVenta[0] ) || ( Z3idProducto != T00052_A3idProducto[0] ) )
            {
               if ( Z41cantidadDetalleVenta != T00052_A41cantidadDetalleVenta[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"cantidadDetalleVenta");
                  GXUtil.WriteLogRaw("Old: ",Z41cantidadDetalleVenta);
                  GXUtil.WriteLogRaw("Current: ",T00052_A41cantidadDetalleVenta[0]);
               }
               if ( Z3idProducto != T00052_A3idProducto[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"idProducto");
                  GXUtil.WriteLogRaw("Old: ",Z3idProducto);
                  GXUtil.WriteLogRaw("Current: ",T00052_A3idProducto[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"VentaidDetalle"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0510( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0510( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0510( 0) ;
            CheckOptimisticConcurrency0510( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0510( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0510( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000528 */
                     pr_default.execute(22, new Object[] {A5idVenta, A34idDetalleVenta, A41cantidadDetalleVenta, A3idProducto});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("VentaidDetalle") ;
                     if ( (pr_default.getStatus(22) == 1) )
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
               Load0510( ) ;
            }
            EndLevel0510( ) ;
         }
         CloseExtendedTableCursors0510( ) ;
      }

      protected void Update0510( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0510( ) ;
         }
         if ( ( nIsMod_10 != 0 ) || ( nIsDirty_10 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency0510( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm0510( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate0510( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000529 */
                        pr_default.execute(23, new Object[] {A41cantidadDetalleVenta, A3idProducto, A5idVenta, A34idDetalleVenta});
                        pr_default.close(23);
                        dsDefault.SmartCacheProvider.SetUpdated("VentaidDetalle") ;
                        if ( (pr_default.getStatus(23) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VentaidDetalle"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate0510( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey0510( ) ;
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
               EndLevel0510( ) ;
            }
         }
         CloseExtendedTableCursors0510( ) ;
      }

      protected void DeferredUpdate0510( )
      {
      }

      protected void Delete0510( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0510( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0510( ) ;
            AfterConfirm0510( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0510( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000530 */
                  pr_default.execute(24, new Object[] {A5idVenta, A34idDetalleVenta});
                  pr_default.close(24);
                  dsDefault.SmartCacheProvider.SetUpdated("VentaidDetalle") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0510( ) ;
         Gx_mode = sMode10;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0510( )
      {
         standaloneModal0510( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000531 */
            pr_default.execute(25, new Object[] {A3idProducto});
            A19descripcionProducto = T000531_A19descripcionProducto[0];
            A21precioProducto = T000531_A21precioProducto[0];
            pr_default.close(25);
            A42subtotalDetalleVenta = (decimal)(A21precioProducto*A41cantidadDetalleVenta);
            if ( IsIns( )  )
            {
               A39totalNetoVenta = (decimal)(O39totalNetoVenta+A42subtotalDetalleVenta);
               n39totalNetoVenta = false;
               AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
            }
            else
            {
               if ( IsUpd( )  )
               {
                  A39totalNetoVenta = (decimal)(O39totalNetoVenta+A42subtotalDetalleVenta-O42subtotalDetalleVenta);
                  n39totalNetoVenta = false;
                  AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
               }
               else
               {
                  if ( IsDlt( )  )
                  {
                     A39totalNetoVenta = (decimal)(O39totalNetoVenta-O42subtotalDetalleVenta);
                     n39totalNetoVenta = false;
                     AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
                  }
               }
            }
            A40totalAPagarVenta = (decimal)(A39totalNetoVenta+(A39totalNetoVenta*A31porcentajeIVA)/ (decimal)(100));
            AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         }
      }

      protected void EndLevel0510( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0510( )
      {
         /* Scan By routine */
         /* Using cursor T000532 */
         pr_default.execute(26, new Object[] {A5idVenta});
         RcdFound10 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound10 = 1;
            A34idDetalleVenta = T000532_A34idDetalleVenta[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0510( )
      {
         /* Scan next routine */
         pr_default.readNext(26);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound10 = 1;
            A34idDetalleVenta = T000532_A34idDetalleVenta[0];
         }
      }

      protected void ScanEnd0510( )
      {
         pr_default.close(26);
      }

      protected void AfterConfirm0510( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0510( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0510( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0510( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0510( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0510( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0510( )
      {
         edtidDetalleVenta_Enabled = 0;
         AssignProp("", false, edtidDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtidProducto_Enabled = 0;
         AssignProp("", false, edtidProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtdescripcionProducto_Enabled = 0;
         AssignProp("", false, edtdescripcionProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdescripcionProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtprecioProducto_Enabled = 0;
         AssignProp("", false, edtprecioProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtprecioProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtcantidadDetalleVenta_Enabled = 0;
         AssignProp("", false, edtcantidadDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtcantidadDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtsubtotalDetalleVenta_Enabled = 0;
         AssignProp("", false, edtsubtotalDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtsubtotalDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
      }

      protected void send_integrity_lvl_hashes0510( )
      {
      }

      protected void send_integrity_lvl_hashes055( )
      {
      }

      protected void SubsflControlProps_7810( )
      {
         edtidDetalleVenta_Internalname = "IDDETALLEVENTA_"+sGXsfl_78_idx;
         edtidProducto_Internalname = "IDPRODUCTO_"+sGXsfl_78_idx;
         imgprompt_3_Internalname = "PROMPT_3_"+sGXsfl_78_idx;
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx;
         edtprecioProducto_Internalname = "PRECIOPRODUCTO_"+sGXsfl_78_idx;
         edtcantidadDetalleVenta_Internalname = "CANTIDADDETALLEVENTA_"+sGXsfl_78_idx;
         edtsubtotalDetalleVenta_Internalname = "SUBTOTALDETALLEVENTA_"+sGXsfl_78_idx;
      }

      protected void SubsflControlProps_fel_7810( )
      {
         edtidDetalleVenta_Internalname = "IDDETALLEVENTA_"+sGXsfl_78_fel_idx;
         edtidProducto_Internalname = "IDPRODUCTO_"+sGXsfl_78_fel_idx;
         imgprompt_3_Internalname = "PROMPT_3_"+sGXsfl_78_fel_idx;
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO_"+sGXsfl_78_fel_idx;
         edtprecioProducto_Internalname = "PRECIOPRODUCTO_"+sGXsfl_78_fel_idx;
         edtcantidadDetalleVenta_Internalname = "CANTIDADDETALLEVENTA_"+sGXsfl_78_fel_idx;
         edtsubtotalDetalleVenta_Internalname = "SUBTOTALDETALLEVENTA_"+sGXsfl_78_fel_idx;
      }

      protected void AddRow0510( )
      {
         nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
         SubsflControlProps_7810( ) ;
         SendRow0510( ) ;
      }

      protected void SendRow0510( )
      {
         Gridventa_iddetalleRow = GXWebRow.GetNew(context);
         if ( subGridventa_iddetalle_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridventa_iddetalle_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridventa_iddetalle_Class, "") != 0 )
            {
               subGridventa_iddetalle_Linesclass = subGridventa_iddetalle_Class+"Odd";
            }
         }
         else if ( subGridventa_iddetalle_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridventa_iddetalle_Backstyle = 0;
            subGridventa_iddetalle_Backcolor = subGridventa_iddetalle_Allbackcolor;
            if ( StringUtil.StrCmp(subGridventa_iddetalle_Class, "") != 0 )
            {
               subGridventa_iddetalle_Linesclass = subGridventa_iddetalle_Class+"Uniform";
            }
         }
         else if ( subGridventa_iddetalle_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridventa_iddetalle_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridventa_iddetalle_Class, "") != 0 )
            {
               subGridventa_iddetalle_Linesclass = subGridventa_iddetalle_Class+"Odd";
            }
            subGridventa_iddetalle_Backcolor = (int)(0x0);
         }
         else if ( subGridventa_iddetalle_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridventa_iddetalle_Backstyle = 1;
            if ( ((int)((nGXsfl_78_idx) % (2))) == 0 )
            {
               subGridventa_iddetalle_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridventa_iddetalle_Class, "") != 0 )
               {
                  subGridventa_iddetalle_Linesclass = subGridventa_iddetalle_Class+"Even";
               }
            }
            else
            {
               subGridventa_iddetalle_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridventa_iddetalle_Class, "") != 0 )
               {
                  subGridventa_iddetalle_Linesclass = subGridventa_iddetalle_Class+"Odd";
               }
            }
         }
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPRODUCTO_"+sGXsfl_78_idx+"'), id:'"+"IDPRODUCTO_"+sGXsfl_78_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_10_"+sGXsfl_78_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_10_" + sGXsfl_78_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_78_idx + "',78)\"";
         ROClassString = "Attribute";
         Gridventa_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidDetalleVenta_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34idDetalleVenta), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A34idDetalleVenta), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,79);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidDetalleVenta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtidDetalleVenta_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_10_" + sGXsfl_78_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_78_idx + "',78)\"";
         ROClassString = "Attribute";
         Gridventa_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")),((edtidProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9")) : context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,80);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtidProducto_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         Gridventa_iddetalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_3_Internalname,(String)sImgUrl,(String)imgprompt_3_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_3_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridventa_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdescripcionProducto_Internalname,(String)A19descripcionProducto,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdescripcionProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdescripcionProducto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridventa_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprecioProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")),((edtprecioProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99")) : context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprecioProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtprecioProducto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Precio",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_10_" + sGXsfl_78_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_78_idx + "',78)\"";
         ROClassString = "Attribute";
         Gridventa_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantidadDetalleVenta_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A41cantidadDetalleVenta), 4, 0, ".", "")),((edtcantidadDetalleVenta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A41cantidadDetalleVenta), "ZZZ9")) : context.localUtil.Format( (decimal)(A41cantidadDetalleVenta), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,83);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantidadDetalleVenta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcantidadDetalleVenta_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridventa_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubtotalDetalleVenta_Internalname,StringUtil.LTrim( StringUtil.NToC( A42subtotalDetalleVenta, 10, 2, ".", "")),((edtsubtotalDetalleVenta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A42subtotalDetalleVenta, "ZZZZZZ9.99")) : context.localUtil.Format( A42subtotalDetalleVenta, "ZZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubtotalDetalleVenta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubtotalDetalleVenta_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Precio",(String)"right",(bool)false,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridventa_iddetalleRow);
         send_integrity_lvl_hashes0510( ) ;
         GXCCtl = "Z34idDetalleVenta_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34idDetalleVenta), 4, 0, ".", "")));
         GXCCtl = "Z41cantidadDetalleVenta_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41cantidadDetalleVenta), 4, 0, ".", "")));
         GXCCtl = "Z3idProducto_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", "")));
         GXCCtl = "O42subtotalDetalleVenta_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O42subtotalDetalleVenta, 10, 2, ".", "")));
         GXCCtl = "nRcdDeleted_10_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_10), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_10_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_10), 4, 0, ".", "")));
         GXCCtl = "nIsMod_10_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_10), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IDDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleVenta_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CANTIDADDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleVenta_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBTOTALDETALLEVENTA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleVenta_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_3_"+sGXsfl_78_idx+"Link", StringUtil.RTrim( imgprompt_3_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridventa_iddetalleContainer.AddRow(Gridventa_iddetalleRow);
      }

      protected void ReadRow0510( )
      {
         nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
         SubsflControlProps_7810( ) ;
         edtidDetalleVenta_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDDETALLEVENTA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtidProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtdescripcionProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtprecioProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtcantidadDetalleVenta_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDADDETALLEVENTA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtsubtotalDetalleVenta_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBTOTALDETALLEVENTA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         imgprompt_1_Link = cgiGet( "PROMPT_3_"+sGXsfl_78_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtidDetalleVenta_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidDetalleVenta_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "IDDETALLEVENTA_" + sGXsfl_78_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidDetalleVenta_Internalname;
            wbErr = true;
            A34idDetalleVenta = 0;
         }
         else
         {
            A34idDetalleVenta = (short)(context.localUtil.CToN( cgiGet( edtidDetalleVenta_Internalname), ".", ","));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "IDPRODUCTO_" + sGXsfl_78_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            wbErr = true;
            A3idProducto = 0;
         }
         else
         {
            A3idProducto = (short)(context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ","));
         }
         A19descripcionProducto = cgiGet( edtdescripcionProducto_Internalname);
         A21precioProducto = context.localUtil.CToN( cgiGet( edtprecioProducto_Internalname), ".", ",");
         if ( ( ( context.localUtil.CToN( cgiGet( edtcantidadDetalleVenta_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantidadDetalleVenta_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CANTIDADDETALLEVENTA_" + sGXsfl_78_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcantidadDetalleVenta_Internalname;
            wbErr = true;
            A41cantidadDetalleVenta = 0;
         }
         else
         {
            A41cantidadDetalleVenta = (short)(context.localUtil.CToN( cgiGet( edtcantidadDetalleVenta_Internalname), ".", ","));
         }
         A42subtotalDetalleVenta = context.localUtil.CToN( cgiGet( edtsubtotalDetalleVenta_Internalname), ".", ",");
         GXCCtl = "Z34idDetalleVenta_" + sGXsfl_78_idx;
         Z34idDetalleVenta = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z41cantidadDetalleVenta_" + sGXsfl_78_idx;
         Z41cantidadDetalleVenta = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z3idProducto_" + sGXsfl_78_idx;
         Z3idProducto = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "O42subtotalDetalleVenta_" + sGXsfl_78_idx;
         O42subtotalDetalleVenta = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",");
         GXCCtl = "nRcdDeleted_10_" + sGXsfl_78_idx;
         nRcdDeleted_10 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_10_" + sGXsfl_78_idx;
         nRcdExists_10 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_10_" + sGXsfl_78_idx;
         nIsMod_10 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtidDetalleVenta_Enabled = edtidDetalleVenta_Enabled;
      }

      protected void ConfirmValues050( )
      {
         nGXsfl_78_idx = 0;
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
         SubsflControlProps_7810( ) ;
         while ( nGXsfl_78_idx < nRC_GXsfl_78 )
         {
            nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
            sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
            SubsflControlProps_7810( ) ;
            ChangePostValue( "Z34idDetalleVenta_"+sGXsfl_78_idx, cgiGet( "ZT_"+"Z34idDetalleVenta_"+sGXsfl_78_idx)) ;
            DeletePostValue( "ZT_"+"Z34idDetalleVenta_"+sGXsfl_78_idx) ;
            ChangePostValue( "Z41cantidadDetalleVenta_"+sGXsfl_78_idx, cgiGet( "ZT_"+"Z41cantidadDetalleVenta_"+sGXsfl_78_idx)) ;
            DeletePostValue( "ZT_"+"Z41cantidadDetalleVenta_"+sGXsfl_78_idx) ;
            ChangePostValue( "Z3idProducto_"+sGXsfl_78_idx, cgiGet( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx)) ;
            DeletePostValue( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx) ;
         }
         ChangePostValue( "O42subtotalDetalleVenta", cgiGet( "T42subtotalDetalleVenta")) ;
         DeletePostValue( "T42subtotalDetalleVenta") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20207161312998", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 139369), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 139369), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 139369), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("venta.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z5idVenta", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5idVenta), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z37tipoFacturaVenta", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37tipoFacturaVenta), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z30fechaVenta", context.localUtil.DToC( Z30fechaVenta, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z31porcentajeIVA", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31porcentajeIVA), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z1idCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1idCliente), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "O39totalNetoVenta", StringUtil.LTrim( StringUtil.NToC( O39totalNetoVenta, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_78", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_78_idx), 8, 0, ".", "")));
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
         return formatLink("venta.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Venta" ;
      }

      public override String GetPgmdesc( )
      {
         return "Venta" ;
      }

      protected void InitializeNonKey055( )
      {
         A40totalAPagarVenta = 0;
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrimStr( A40totalAPagarVenta, 10, 2));
         A37tipoFacturaVenta = 0;
         AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0));
         A30fechaVenta = DateTime.MinValue;
         AssignAttri("", false, "A30fechaVenta", context.localUtil.Format(A30fechaVenta, "99/99/99"));
         A31porcentajeIVA = 0;
         AssignAttri("", false, "A31porcentajeIVA", StringUtil.LTrimStr( (decimal)(A31porcentajeIVA), 10, 0));
         A39totalNetoVenta = 0;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         A1idCliente = 0;
         AssignAttri("", false, "A1idCliente", StringUtil.LTrimStr( (decimal)(A1idCliente), 4, 0));
         A9nombreCliente = "";
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
         O39totalNetoVenta = A39totalNetoVenta;
         n39totalNetoVenta = false;
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrimStr( A39totalNetoVenta, 10, 2));
         Z37tipoFacturaVenta = 0;
         Z30fechaVenta = DateTime.MinValue;
         Z31porcentajeIVA = 0;
         Z1idCliente = 0;
      }

      protected void InitAll055( )
      {
         A5idVenta = 0;
         AssignAttri("", false, "A5idVenta", StringUtil.LTrimStr( (decimal)(A5idVenta), 4, 0));
         InitializeNonKey055( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0510( )
      {
         A42subtotalDetalleVenta = 0;
         A3idProducto = 0;
         A19descripcionProducto = "";
         A21precioProducto = 0;
         A41cantidadDetalleVenta = 0;
         O42subtotalDetalleVenta = A42subtotalDetalleVenta;
         Z41cantidadDetalleVenta = 0;
         Z3idProducto = 0;
      }

      protected void InitAll0510( )
      {
         A34idDetalleVenta = 0;
         InitializeNonKey0510( ) ;
      }

      protected void StandaloneModalInsert0510( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20207161312103", true, true);
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
         context.AddJavascriptSource("venta.js", "?20207161312104", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties10( )
      {
         edtidDetalleVenta_Enabled = defedtidDetalleVenta_Enabled;
         AssignProp("", false, edtidDetalleVenta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleVenta_Enabled), 5, 0), !bGXsfl_78_Refreshing);
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
         edtidVenta_Internalname = "IDVENTA";
         cmbtipoFacturaVenta_Internalname = "TIPOFACTURAVENTA";
         edtfechaVenta_Internalname = "FECHAVENTA";
         edtporcentajeIVA_Internalname = "PORCENTAJEIVA";
         edttotalNetoVenta_Internalname = "TOTALNETOVENTA";
         edttotalAPagarVenta_Internalname = "TOTALAPAGARVENTA";
         edtidCliente_Internalname = "IDCLIENTE";
         edtnombreCliente_Internalname = "NOMBRECLIENTE";
         lblTitleiddetalle_Internalname = "TITLEIDDETALLE";
         edtidDetalleVenta_Internalname = "IDDETALLEVENTA";
         edtidProducto_Internalname = "IDPRODUCTO";
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO";
         edtprecioProducto_Internalname = "PRECIOPRODUCTO";
         edtcantidadDetalleVenta_Internalname = "CANTIDADDETALLEVENTA";
         edtsubtotalDetalleVenta_Internalname = "SUBTOTALDETALLEVENTA";
         divIddetalletable_Internalname = "IDDETALLETABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_3_Internalname = "PROMPT_3";
         subGridventa_iddetalle_Internalname = "GRIDVENTA_IDDETALLE";
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
         Form.Caption = "Venta";
         edtsubtotalDetalleVenta_Jsonclick = "";
         edtcantidadDetalleVenta_Jsonclick = "";
         edtprecioProducto_Jsonclick = "";
         edtdescripcionProducto_Jsonclick = "";
         imgprompt_3_Visible = 1;
         imgprompt_3_Link = "";
         imgprompt_1_Visible = 1;
         edtidProducto_Jsonclick = "";
         edtidDetalleVenta_Jsonclick = "";
         subGridventa_iddetalle_Class = "Grid";
         subGridventa_iddetalle_Backcolorstyle = 0;
         subGridventa_iddetalle_Allowcollapsing = 0;
         subGridventa_iddetalle_Allowselection = 0;
         edtsubtotalDetalleVenta_Enabled = 0;
         edtcantidadDetalleVenta_Enabled = 1;
         edtprecioProducto_Enabled = 0;
         edtdescripcionProducto_Enabled = 0;
         edtidProducto_Enabled = 1;
         edtidDetalleVenta_Enabled = 1;
         subGridventa_iddetalle_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtnombreCliente_Jsonclick = "";
         edtnombreCliente_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtidCliente_Jsonclick = "";
         edtidCliente_Enabled = 1;
         edttotalAPagarVenta_Jsonclick = "";
         edttotalAPagarVenta_Enabled = 0;
         edttotalNetoVenta_Jsonclick = "";
         edttotalNetoVenta_Enabled = 0;
         edtporcentajeIVA_Jsonclick = "";
         edtporcentajeIVA_Enabled = 1;
         edtfechaVenta_Jsonclick = "";
         edtfechaVenta_Enabled = 1;
         cmbtipoFacturaVenta_Jsonclick = "";
         cmbtipoFacturaVenta.Enabled = 1;
         edtidVenta_Jsonclick = "";
         edtidVenta_Enabled = 1;
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

      protected void gxnrGridventa_iddetalle_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_7810( ) ;
         while ( nGXsfl_78_idx <= nRC_GXsfl_78 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0510( ) ;
            standaloneModal0510( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0510( ) ;
            nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
            sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
            SubsflControlProps_7810( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridventa_iddetalleContainer)) ;
         /* End function gxnrGridventa_iddetalle_newrow */
      }

      protected void init_web_controls( )
      {
         cmbtipoFacturaVenta.Name = "TIPOFACTURAVENTA";
         cmbtipoFacturaVenta.WebTags = "";
         cmbtipoFacturaVenta.addItem("0", "Factura tipo A", 0);
         cmbtipoFacturaVenta.addItem("1", "Factura tipo B", 0);
         cmbtipoFacturaVenta.addItem("2", "Factura tipo C", 0);
         if ( cmbtipoFacturaVenta.ItemCount > 0 )
         {
            A37tipoFacturaVenta = (short)(NumberUtil.Val( cmbtipoFacturaVenta.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0))), "."));
            AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0));
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = cmbtipoFacturaVenta_Internalname;
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

      public void Valid_Idventa( )
      {
         A37tipoFacturaVenta = (short)(NumberUtil.Val( cmbtipoFacturaVenta.CurrentValue, "."));
         cmbtipoFacturaVenta.CurrentValue = StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0);
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T000522 */
         pr_default.execute(16, new Object[] {A5idVenta});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A39totalNetoVenta = T000522_A39totalNetoVenta[0];
            n39totalNetoVenta = T000522_n39totalNetoVenta[0];
         }
         else
         {
            A39totalNetoVenta = 0;
            n39totalNetoVenta = false;
         }
         pr_default.close(16);
         dynload_actions( ) ;
         if ( cmbtipoFacturaVenta.ItemCount > 0 )
         {
            A37tipoFacturaVenta = (short)(NumberUtil.Val( cmbtipoFacturaVenta.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0))), "."));
            cmbtipoFacturaVenta.CurrentValue = StringUtil.LTrimStr( (decimal)(A37tipoFacturaVenta), 4, 0);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbtipoFacturaVenta.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0));
         }
         /*  Sending validation outputs */
         AssignAttri("", false, "A37tipoFacturaVenta", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37tipoFacturaVenta), 4, 0, ".", "")));
         cmbtipoFacturaVenta.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A37tipoFacturaVenta), 4, 0));
         AssignProp("", false, cmbtipoFacturaVenta_Internalname, "Values", cmbtipoFacturaVenta.ToJavascriptSource(), true);
         AssignAttri("", false, "A30fechaVenta", context.localUtil.Format(A30fechaVenta, "99/99/99"));
         AssignAttri("", false, "A31porcentajeIVA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31porcentajeIVA), 10, 0, ".", "")));
         AssignAttri("", false, "A1idCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1idCliente), 4, 0, ".", "")));
         AssignAttri("", false, "A39totalNetoVenta", StringUtil.LTrim( StringUtil.NToC( A39totalNetoVenta, 10, 2, ".", "")));
         AssignAttri("", false, "A40totalAPagarVenta", StringUtil.LTrim( StringUtil.NToC( A40totalAPagarVenta, 10, 2, ".", "")));
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z5idVenta", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5idVenta), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z37tipoFacturaVenta", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37tipoFacturaVenta), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z30fechaVenta", context.localUtil.Format(Z30fechaVenta, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "Z31porcentajeIVA", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31porcentajeIVA), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z1idCliente", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1idCliente), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z39totalNetoVenta", StringUtil.LTrim( StringUtil.NToC( Z39totalNetoVenta, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z40totalAPagarVenta", StringUtil.LTrim( StringUtil.NToC( Z40totalAPagarVenta, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z9nombreCliente", Z9nombreCliente);
         AssignAttri("", false, "O39totalNetoVenta", StringUtil.LTrim( StringUtil.NToC( O39totalNetoVenta, 10, 2, ".", "")));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Idcliente( )
      {
         /* Using cursor T000523 */
         pr_default.execute(17, new Object[] {A1idCliente});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Cliente'.", "ForeignKeyNotFound", 1, "IDCLIENTE");
            AnyError = 1;
            GX_FocusControl = edtidCliente_Internalname;
         }
         A9nombreCliente = T000523_A9nombreCliente[0];
         pr_default.close(17);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A9nombreCliente", A9nombreCliente);
      }

      public void Valid_Idproducto( )
      {
         /* Using cursor T000531 */
         pr_default.execute(25, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No matching 'Producto'.", "ForeignKeyNotFound", 1, "IDPRODUCTO");
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
         }
         A19descripcionProducto = T000531_A19descripcionProducto[0];
         A21precioProducto = T000531_A21precioProducto[0];
         pr_default.close(25);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A19descripcionProducto", A19descripcionProducto);
         AssignAttri("", false, "A21precioProducto", StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")));
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
         setEventMetadata("VALID_IDVENTA","{handler:'Valid_Idventa',iparms:[{av:'cmbtipoFacturaVenta'},{av:'A37tipoFacturaVenta',fld:'TIPOFACTURAVENTA',pic:'ZZZ9'},{av:'A5idVenta',fld:'IDVENTA',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_IDVENTA",",oparms:[{av:'cmbtipoFacturaVenta'},{av:'A37tipoFacturaVenta',fld:'TIPOFACTURAVENTA',pic:'ZZZ9'},{av:'A30fechaVenta',fld:'FECHAVENTA',pic:''},{av:'A31porcentajeIVA',fld:'PORCENTAJEIVA',pic:'ZZZZZZZZZ9'},{av:'A1idCliente',fld:'IDCLIENTE',pic:'ZZZ9'},{av:'A39totalNetoVenta',fld:'TOTALNETOVENTA',pic:'ZZZZZZ9.99'},{av:'A40totalAPagarVenta',fld:'TOTALAPAGARVENTA',pic:'ZZZZZZ9.99'},{av:'A9nombreCliente',fld:'NOMBRECLIENTE',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z5idVenta'},{av:'Z37tipoFacturaVenta'},{av:'Z30fechaVenta'},{av:'Z31porcentajeIVA'},{av:'Z1idCliente'},{av:'Z39totalNetoVenta'},{av:'Z40totalAPagarVenta'},{av:'Z9nombreCliente'},{av:'O39totalNetoVenta'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_TIPOFACTURAVENTA","{handler:'Valid_Tipofacturaventa',iparms:[]");
         setEventMetadata("VALID_TIPOFACTURAVENTA",",oparms:[]}");
         setEventMetadata("VALID_FECHAVENTA","{handler:'Valid_Fechaventa',iparms:[]");
         setEventMetadata("VALID_FECHAVENTA",",oparms:[]}");
         setEventMetadata("VALID_PORCENTAJEIVA","{handler:'Valid_Porcentajeiva',iparms:[]");
         setEventMetadata("VALID_PORCENTAJEIVA",",oparms:[]}");
         setEventMetadata("VALID_TOTALNETOVENTA","{handler:'Valid_Totalnetoventa',iparms:[]");
         setEventMetadata("VALID_TOTALNETOVENTA",",oparms:[]}");
         setEventMetadata("VALID_IDCLIENTE","{handler:'Valid_Idcliente',iparms:[{av:'A1idCliente',fld:'IDCLIENTE',pic:'ZZZ9'},{av:'A9nombreCliente',fld:'NOMBRECLIENTE',pic:''}]");
         setEventMetadata("VALID_IDCLIENTE",",oparms:[{av:'A9nombreCliente',fld:'NOMBRECLIENTE',pic:''}]}");
         setEventMetadata("VALID_IDDETALLEVENTA","{handler:'Valid_Iddetalleventa',iparms:[]");
         setEventMetadata("VALID_IDDETALLEVENTA",",oparms:[]}");
         setEventMetadata("VALID_IDPRODUCTO","{handler:'Valid_Idproducto',iparms:[{av:'A3idProducto',fld:'IDPRODUCTO',pic:'ZZZ9'},{av:'A19descripcionProducto',fld:'DESCRIPCIONPRODUCTO',pic:''},{av:'A21precioProducto',fld:'PRECIOPRODUCTO',pic:'ZZZZZZ9.99'}]");
         setEventMetadata("VALID_IDPRODUCTO",",oparms:[{av:'A19descripcionProducto',fld:'DESCRIPCIONPRODUCTO',pic:''},{av:'A21precioProducto',fld:'PRECIOPRODUCTO',pic:'ZZZZZZ9.99'}]}");
         setEventMetadata("VALID_PRECIOPRODUCTO","{handler:'Valid_Precioproducto',iparms:[]");
         setEventMetadata("VALID_PRECIOPRODUCTO",",oparms:[]}");
         setEventMetadata("VALID_CANTIDADDETALLEVENTA","{handler:'Valid_Cantidaddetalleventa',iparms:[]");
         setEventMetadata("VALID_CANTIDADDETALLEVENTA",",oparms:[]}");
         setEventMetadata("VALID_SUBTOTALDETALLEVENTA","{handler:'Valid_Subtotaldetalleventa',iparms:[]");
         setEventMetadata("VALID_SUBTOTALDETALLEVENTA",",oparms:[]}");
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
         pr_default.close(25);
         pr_default.close(4);
         pr_default.close(17);
         pr_default.close(16);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z30fechaVenta = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
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
         A30fechaVenta = DateTime.MinValue;
         sImgUrl = "";
         A9nombreCliente = "";
         lblTitleiddetalle_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridventa_iddetalleContainer = new GXWebGrid( context);
         Gridventa_iddetalleColumn = new GXWebColumn();
         A19descripcionProducto = "";
         sMode10 = "";
         sStyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         Z9nombreCliente = "";
         T000511_A5idVenta = new short[1] ;
         T000511_A37tipoFacturaVenta = new short[1] ;
         T000511_A30fechaVenta = new DateTime[] {DateTime.MinValue} ;
         T000511_A31porcentajeIVA = new long[1] ;
         T000511_A9nombreCliente = new String[] {""} ;
         T000511_A1idCliente = new short[1] ;
         T000511_A39totalNetoVenta = new decimal[1] ;
         T000511_n39totalNetoVenta = new bool[] {false} ;
         T00059_A39totalNetoVenta = new decimal[1] ;
         T00059_n39totalNetoVenta = new bool[] {false} ;
         T00057_A9nombreCliente = new String[] {""} ;
         T000513_A39totalNetoVenta = new decimal[1] ;
         T000513_n39totalNetoVenta = new bool[] {false} ;
         T000514_A9nombreCliente = new String[] {""} ;
         T000515_A5idVenta = new short[1] ;
         T00056_A5idVenta = new short[1] ;
         T00056_A37tipoFacturaVenta = new short[1] ;
         T00056_A30fechaVenta = new DateTime[] {DateTime.MinValue} ;
         T00056_A31porcentajeIVA = new long[1] ;
         T00056_A1idCliente = new short[1] ;
         sMode5 = "";
         T000516_A5idVenta = new short[1] ;
         T000517_A5idVenta = new short[1] ;
         T00055_A5idVenta = new short[1] ;
         T00055_A37tipoFacturaVenta = new short[1] ;
         T00055_A30fechaVenta = new DateTime[] {DateTime.MinValue} ;
         T00055_A31porcentajeIVA = new long[1] ;
         T00055_A1idCliente = new short[1] ;
         T000522_A39totalNetoVenta = new decimal[1] ;
         T000522_n39totalNetoVenta = new bool[] {false} ;
         T000523_A9nombreCliente = new String[] {""} ;
         T000524_A5idVenta = new short[1] ;
         Z19descripcionProducto = "";
         T000525_A5idVenta = new short[1] ;
         T000525_A34idDetalleVenta = new short[1] ;
         T000525_A19descripcionProducto = new String[] {""} ;
         T000525_A21precioProducto = new decimal[1] ;
         T000525_A41cantidadDetalleVenta = new short[1] ;
         T000525_A3idProducto = new short[1] ;
         T00054_A19descripcionProducto = new String[] {""} ;
         T00054_A21precioProducto = new decimal[1] ;
         T000526_A19descripcionProducto = new String[] {""} ;
         T000526_A21precioProducto = new decimal[1] ;
         T000527_A5idVenta = new short[1] ;
         T000527_A34idDetalleVenta = new short[1] ;
         T00053_A5idVenta = new short[1] ;
         T00053_A34idDetalleVenta = new short[1] ;
         T00053_A41cantidadDetalleVenta = new short[1] ;
         T00053_A3idProducto = new short[1] ;
         T00052_A5idVenta = new short[1] ;
         T00052_A34idDetalleVenta = new short[1] ;
         T00052_A41cantidadDetalleVenta = new short[1] ;
         T00052_A3idProducto = new short[1] ;
         T000531_A19descripcionProducto = new String[] {""} ;
         T000531_A21precioProducto = new decimal[1] ;
         T000532_A5idVenta = new short[1] ;
         T000532_A34idDetalleVenta = new short[1] ;
         Gridventa_iddetalleRow = new GXWebRow();
         subGridventa_iddetalle_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ30fechaVenta = DateTime.MinValue;
         ZZ9nombreCliente = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.venta__default(),
            new Object[][] {
                new Object[] {
               T00052_A5idVenta, T00052_A34idDetalleVenta, T00052_A41cantidadDetalleVenta, T00052_A3idProducto
               }
               , new Object[] {
               T00053_A5idVenta, T00053_A34idDetalleVenta, T00053_A41cantidadDetalleVenta, T00053_A3idProducto
               }
               , new Object[] {
               T00054_A19descripcionProducto, T00054_A21precioProducto
               }
               , new Object[] {
               T00055_A5idVenta, T00055_A37tipoFacturaVenta, T00055_A30fechaVenta, T00055_A31porcentajeIVA, T00055_A1idCliente
               }
               , new Object[] {
               T00056_A5idVenta, T00056_A37tipoFacturaVenta, T00056_A30fechaVenta, T00056_A31porcentajeIVA, T00056_A1idCliente
               }
               , new Object[] {
               T00057_A9nombreCliente
               }
               , new Object[] {
               T00059_A39totalNetoVenta, T00059_n39totalNetoVenta
               }
               , new Object[] {
               T000511_A5idVenta, T000511_A37tipoFacturaVenta, T000511_A30fechaVenta, T000511_A31porcentajeIVA, T000511_A9nombreCliente, T000511_A1idCliente, T000511_A39totalNetoVenta, T000511_n39totalNetoVenta
               }
               , new Object[] {
               T000513_A39totalNetoVenta, T000513_n39totalNetoVenta
               }
               , new Object[] {
               T000514_A9nombreCliente
               }
               , new Object[] {
               T000515_A5idVenta
               }
               , new Object[] {
               T000516_A5idVenta
               }
               , new Object[] {
               T000517_A5idVenta
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000522_A39totalNetoVenta, T000522_n39totalNetoVenta
               }
               , new Object[] {
               T000523_A9nombreCliente
               }
               , new Object[] {
               T000524_A5idVenta
               }
               , new Object[] {
               T000525_A5idVenta, T000525_A34idDetalleVenta, T000525_A19descripcionProducto, T000525_A21precioProducto, T000525_A41cantidadDetalleVenta, T000525_A3idProducto
               }
               , new Object[] {
               T000526_A19descripcionProducto, T000526_A21precioProducto
               }
               , new Object[] {
               T000527_A5idVenta, T000527_A34idDetalleVenta
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000531_A19descripcionProducto, T000531_A21precioProducto
               }
               , new Object[] {
               T000532_A5idVenta, T000532_A34idDetalleVenta
               }
            }
         );
      }

      private short nIsMod_10 ;
      private short Z5idVenta ;
      private short Z37tipoFacturaVenta ;
      private short Z1idCliente ;
      private short Z34idDetalleVenta ;
      private short Z41cantidadDetalleVenta ;
      private short Z3idProducto ;
      private short nRcdDeleted_10 ;
      private short nRcdExists_10 ;
      private short GxWebError ;
      private short A5idVenta ;
      private short A1idCliente ;
      private short A3idProducto ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A37tipoFacturaVenta ;
      private short subGridventa_iddetalle_Backcolorstyle ;
      private short A34idDetalleVenta ;
      private short A41cantidadDetalleVenta ;
      private short subGridventa_iddetalle_Allowselection ;
      private short subGridventa_iddetalle_Allowhovering ;
      private short subGridventa_iddetalle_Allowcollapsing ;
      private short subGridventa_iddetalle_Collapsed ;
      private short nBlankRcdCount10 ;
      private short RcdFound10 ;
      private short nBlankRcdUsr10 ;
      private short GX_JID ;
      private short RcdFound5 ;
      private short nIsDirty_5 ;
      private short Gx_BScreen ;
      private short nIsDirty_10 ;
      private short subGridventa_iddetalle_Backstyle ;
      private short gxajaxcallmode ;
      private short ZZ5idVenta ;
      private short ZZ37tipoFacturaVenta ;
      private short ZZ1idCliente ;
      private int nRC_GXsfl_78 ;
      private int nGXsfl_78_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtidVenta_Enabled ;
      private int edtfechaVenta_Enabled ;
      private int edtporcentajeIVA_Enabled ;
      private int edttotalNetoVenta_Enabled ;
      private int edttotalAPagarVenta_Enabled ;
      private int edtidCliente_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtnombreCliente_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtidDetalleVenta_Enabled ;
      private int edtidProducto_Enabled ;
      private int edtdescripcionProducto_Enabled ;
      private int edtprecioProducto_Enabled ;
      private int edtcantidadDetalleVenta_Enabled ;
      private int edtsubtotalDetalleVenta_Enabled ;
      private int subGridventa_iddetalle_Selectedindex ;
      private int subGridventa_iddetalle_Selectioncolor ;
      private int subGridventa_iddetalle_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridventa_iddetalle_Backcolor ;
      private int subGridventa_iddetalle_Allbackcolor ;
      private int imgprompt_3_Visible ;
      private int defedtidDetalleVenta_Enabled ;
      private int idxLst ;
      private long Z31porcentajeIVA ;
      private long A31porcentajeIVA ;
      private long GRIDVENTA_IDDETALLE_nFirstRecordOnPage ;
      private long ZZ31porcentajeIVA ;
      private decimal O39totalNetoVenta ;
      private decimal O42subtotalDetalleVenta ;
      private decimal A39totalNetoVenta ;
      private decimal A40totalAPagarVenta ;
      private decimal A21precioProducto ;
      private decimal A42subtotalDetalleVenta ;
      private decimal B39totalNetoVenta ;
      private decimal s39totalNetoVenta ;
      private decimal s40totalAPagarVenta ;
      private decimal O40totalAPagarVenta ;
      private decimal T42subtotalDetalleVenta ;
      private decimal Z39totalNetoVenta ;
      private decimal Z21precioProducto ;
      private decimal Z40totalAPagarVenta ;
      private decimal ZZ39totalNetoVenta ;
      private decimal ZZ40totalAPagarVenta ;
      private decimal ZO39totalNetoVenta ;
      private String sPrefix ;
      private String sGXsfl_78_idx="0001" ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtidVenta_Internalname ;
      private String cmbtipoFacturaVenta_Internalname ;
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
      private String edtidVenta_Jsonclick ;
      private String cmbtipoFacturaVenta_Jsonclick ;
      private String edtfechaVenta_Internalname ;
      private String edtfechaVenta_Jsonclick ;
      private String edtporcentajeIVA_Internalname ;
      private String edtporcentajeIVA_Jsonclick ;
      private String edttotalNetoVenta_Internalname ;
      private String edttotalNetoVenta_Jsonclick ;
      private String edttotalAPagarVenta_Internalname ;
      private String edttotalAPagarVenta_Jsonclick ;
      private String edtidCliente_Internalname ;
      private String edtidCliente_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtnombreCliente_Internalname ;
      private String edtnombreCliente_Jsonclick ;
      private String divIddetalletable_Internalname ;
      private String lblTitleiddetalle_Internalname ;
      private String lblTitleiddetalle_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridventa_iddetalle_Header ;
      private String sMode10 ;
      private String edtidDetalleVenta_Internalname ;
      private String edtidProducto_Internalname ;
      private String edtdescripcionProducto_Internalname ;
      private String edtprecioProducto_Internalname ;
      private String edtcantidadDetalleVenta_Internalname ;
      private String edtsubtotalDetalleVenta_Internalname ;
      private String sStyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sMode5 ;
      private String imgprompt_3_Internalname ;
      private String sGXsfl_78_fel_idx="0001" ;
      private String subGridventa_iddetalle_Class ;
      private String subGridventa_iddetalle_Linesclass ;
      private String imgprompt_3_Link ;
      private String ROClassString ;
      private String edtidDetalleVenta_Jsonclick ;
      private String edtidProducto_Jsonclick ;
      private String edtdescripcionProducto_Jsonclick ;
      private String edtprecioProducto_Jsonclick ;
      private String edtcantidadDetalleVenta_Jsonclick ;
      private String edtsubtotalDetalleVenta_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridventa_iddetalle_Internalname ;
      private DateTime Z30fechaVenta ;
      private DateTime A30fechaVenta ;
      private DateTime ZZ30fechaVenta ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n39totalNetoVenta ;
      private bool bGXsfl_78_Refreshing=false ;
      private String A9nombreCliente ;
      private String A19descripcionProducto ;
      private String Z9nombreCliente ;
      private String Z19descripcionProducto ;
      private String ZZ9nombreCliente ;
      private GXWebGrid Gridventa_iddetalleContainer ;
      private GXWebRow Gridventa_iddetalleRow ;
      private GXWebColumn Gridventa_iddetalleColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbtipoFacturaVenta ;
      private IDataStoreProvider pr_default ;
      private short[] T000511_A5idVenta ;
      private short[] T000511_A37tipoFacturaVenta ;
      private DateTime[] T000511_A30fechaVenta ;
      private long[] T000511_A31porcentajeIVA ;
      private String[] T000511_A9nombreCliente ;
      private short[] T000511_A1idCliente ;
      private decimal[] T000511_A39totalNetoVenta ;
      private bool[] T000511_n39totalNetoVenta ;
      private decimal[] T00059_A39totalNetoVenta ;
      private bool[] T00059_n39totalNetoVenta ;
      private String[] T00057_A9nombreCliente ;
      private decimal[] T000513_A39totalNetoVenta ;
      private bool[] T000513_n39totalNetoVenta ;
      private String[] T000514_A9nombreCliente ;
      private short[] T000515_A5idVenta ;
      private short[] T00056_A5idVenta ;
      private short[] T00056_A37tipoFacturaVenta ;
      private DateTime[] T00056_A30fechaVenta ;
      private long[] T00056_A31porcentajeIVA ;
      private short[] T00056_A1idCliente ;
      private short[] T000516_A5idVenta ;
      private short[] T000517_A5idVenta ;
      private short[] T00055_A5idVenta ;
      private short[] T00055_A37tipoFacturaVenta ;
      private DateTime[] T00055_A30fechaVenta ;
      private long[] T00055_A31porcentajeIVA ;
      private short[] T00055_A1idCliente ;
      private decimal[] T000522_A39totalNetoVenta ;
      private bool[] T000522_n39totalNetoVenta ;
      private String[] T000523_A9nombreCliente ;
      private short[] T000524_A5idVenta ;
      private short[] T000525_A5idVenta ;
      private short[] T000525_A34idDetalleVenta ;
      private String[] T000525_A19descripcionProducto ;
      private decimal[] T000525_A21precioProducto ;
      private short[] T000525_A41cantidadDetalleVenta ;
      private short[] T000525_A3idProducto ;
      private String[] T00054_A19descripcionProducto ;
      private decimal[] T00054_A21precioProducto ;
      private String[] T000526_A19descripcionProducto ;
      private decimal[] T000526_A21precioProducto ;
      private short[] T000527_A5idVenta ;
      private short[] T000527_A34idDetalleVenta ;
      private short[] T00053_A5idVenta ;
      private short[] T00053_A34idDetalleVenta ;
      private short[] T00053_A41cantidadDetalleVenta ;
      private short[] T00053_A3idProducto ;
      private short[] T00052_A5idVenta ;
      private short[] T00052_A34idDetalleVenta ;
      private short[] T00052_A41cantidadDetalleVenta ;
      private short[] T00052_A3idProducto ;
      private String[] T000531_A19descripcionProducto ;
      private decimal[] T000531_A21precioProducto ;
      private short[] T000532_A5idVenta ;
      private short[] T000532_A34idDetalleVenta ;
      private GXWebForm Form ;
   }

   public class venta__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000516 ;
          prmT000516 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000517 ;
          prmT000517 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000518 ;
          prmT000518 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoFacturaVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fechaVenta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@porcentajeIVA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000519 ;
          prmT000519 = new Object[] {
          new Object[] {"@tipoFacturaVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fechaVenta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@porcentajeIVA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000520 ;
          prmT000520 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000524 ;
          prmT000524 = new Object[] {
          } ;
          Object[] prmT000525 ;
          prmT000525 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000526 ;
          prmT000526 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000527 ;
          prmT000527 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000528 ;
          prmT000528 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@cantidadDetalleVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000529 ;
          prmT000529 = new Object[] {
          new Object[] {"@cantidadDetalleVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000530 ;
          prmT000530 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000532 ;
          prmT000532 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000522 ;
          prmT000522 = new Object[] {
          new Object[] {"@idVenta",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000523 ;
          prmT000523 = new Object[] {
          new Object[] {"@idCliente",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000531 ;
          prmT000531 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [idVenta], [idDetalleVenta], [cantidadDetalleVenta], [idProducto] FROM [VentaidDetalle] WITH (UPDLOCK) WHERE [idVenta] = @idVenta AND [idDetalleVenta] = @idDetalleVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00053", "SELECT [idVenta], [idDetalleVenta], [cantidadDetalleVenta], [idProducto] FROM [VentaidDetalle] WHERE [idVenta] = @idVenta AND [idDetalleVenta] = @idDetalleVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00054", "SELECT [descripcionProducto], [precioProducto] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00055", "SELECT [idVenta], [tipoFacturaVenta], [fechaVenta], [porcentajeIVA], [idCliente] FROM [Venta] WITH (UPDLOCK) WHERE [idVenta] = @idVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00056", "SELECT [idVenta], [tipoFacturaVenta], [fechaVenta], [porcentajeIVA], [idCliente] FROM [Venta] WHERE [idVenta] = @idVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00057", "SELECT [nombreCliente] FROM [Cliente] WHERE [idCliente] = @idCliente ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00059", "SELECT COALESCE( T1.[totalNetoVenta], 0) AS totalNetoVenta FROM (SELECT SUM(T3.[precioProducto] * CAST(T2.[cantidadDetalleVenta] AS decimal( 20, 10))) AS totalNetoVenta, T2.[idVenta] FROM ([VentaidDetalle] T2 WITH (UPDLOCK) INNER JOIN [Producto] T3 ON T3.[idProducto] = T2.[idProducto]) GROUP BY T2.[idVenta] ) T1 WHERE T1.[idVenta] = @idVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000511", "SELECT TM1.[idVenta], TM1.[tipoFacturaVenta], TM1.[fechaVenta], TM1.[porcentajeIVA], T3.[nombreCliente], TM1.[idCliente], COALESCE( T2.[totalNetoVenta], 0) AS totalNetoVenta FROM (([Venta] TM1 LEFT JOIN (SELECT SUM(T5.[precioProducto] * CAST(T4.[cantidadDetalleVenta] AS decimal( 20, 10))) AS totalNetoVenta, T4.[idVenta] FROM ([VentaidDetalle] T4 INNER JOIN [Producto] T5 ON T5.[idProducto] = T4.[idProducto]) GROUP BY T4.[idVenta] ) T2 ON T2.[idVenta] = TM1.[idVenta]) INNER JOIN [Cliente] T3 ON T3.[idCliente] = TM1.[idCliente]) WHERE TM1.[idVenta] = @idVenta ORDER BY TM1.[idVenta]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000513", "SELECT COALESCE( T1.[totalNetoVenta], 0) AS totalNetoVenta FROM (SELECT SUM(T3.[precioProducto] * CAST(T2.[cantidadDetalleVenta] AS decimal( 20, 10))) AS totalNetoVenta, T2.[idVenta] FROM ([VentaidDetalle] T2 WITH (UPDLOCK) INNER JOIN [Producto] T3 ON T3.[idProducto] = T2.[idProducto]) GROUP BY T2.[idVenta] ) T1 WHERE T1.[idVenta] = @idVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000514", "SELECT [nombreCliente] FROM [Cliente] WHERE [idCliente] = @idCliente ",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000515", "SELECT [idVenta] FROM [Venta] WHERE [idVenta] = @idVenta  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000516", "SELECT TOP 1 [idVenta] FROM [Venta] WHERE ( [idVenta] > @idVenta) ORDER BY [idVenta]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000517", "SELECT TOP 1 [idVenta] FROM [Venta] WHERE ( [idVenta] < @idVenta) ORDER BY [idVenta] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000517,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000518", "INSERT INTO [Venta]([idVenta], [tipoFacturaVenta], [fechaVenta], [porcentajeIVA], [idCliente]) VALUES(@idVenta, @tipoFacturaVenta, @fechaVenta, @porcentajeIVA, @idCliente)", GxErrorMask.GX_NOMASK,prmT000518)
             ,new CursorDef("T000519", "UPDATE [Venta] SET [tipoFacturaVenta]=@tipoFacturaVenta, [fechaVenta]=@fechaVenta, [porcentajeIVA]=@porcentajeIVA, [idCliente]=@idCliente  WHERE [idVenta] = @idVenta", GxErrorMask.GX_NOMASK,prmT000519)
             ,new CursorDef("T000520", "DELETE FROM [Venta]  WHERE [idVenta] = @idVenta", GxErrorMask.GX_NOMASK,prmT000520)
             ,new CursorDef("T000522", "SELECT COALESCE( T1.[totalNetoVenta], 0) AS totalNetoVenta FROM (SELECT SUM(T3.[precioProducto] * CAST(T2.[cantidadDetalleVenta] AS decimal( 20, 10))) AS totalNetoVenta, T2.[idVenta] FROM ([VentaidDetalle] T2 WITH (UPDLOCK) INNER JOIN [Producto] T3 ON T3.[idProducto] = T2.[idProducto]) GROUP BY T2.[idVenta] ) T1 WHERE T1.[idVenta] = @idVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT000522,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000523", "SELECT [nombreCliente] FROM [Cliente] WHERE [idCliente] = @idCliente ",true, GxErrorMask.GX_NOMASK, false, this,prmT000523,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000524", "SELECT [idVenta] FROM [Venta] ORDER BY [idVenta]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000524,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000525", "SELECT T1.[idVenta], T1.[idDetalleVenta], T2.[descripcionProducto], T2.[precioProducto], T1.[cantidadDetalleVenta], T1.[idProducto] FROM ([VentaidDetalle] T1 INNER JOIN [Producto] T2 ON T2.[idProducto] = T1.[idProducto]) WHERE T1.[idVenta] = @idVenta and T1.[idDetalleVenta] = @idDetalleVenta ORDER BY T1.[idVenta], T1.[idDetalleVenta] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000525,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000526", "SELECT [descripcionProducto], [precioProducto] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000526,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000527", "SELECT [idVenta], [idDetalleVenta] FROM [VentaidDetalle] WHERE [idVenta] = @idVenta AND [idDetalleVenta] = @idDetalleVenta ",true, GxErrorMask.GX_NOMASK, false, this,prmT000527,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000528", "INSERT INTO [VentaidDetalle]([idVenta], [idDetalleVenta], [cantidadDetalleVenta], [idProducto]) VALUES(@idVenta, @idDetalleVenta, @cantidadDetalleVenta, @idProducto)", GxErrorMask.GX_NOMASK,prmT000528)
             ,new CursorDef("T000529", "UPDATE [VentaidDetalle] SET [cantidadDetalleVenta]=@cantidadDetalleVenta, [idProducto]=@idProducto  WHERE [idVenta] = @idVenta AND [idDetalleVenta] = @idDetalleVenta", GxErrorMask.GX_NOMASK,prmT000529)
             ,new CursorDef("T000530", "DELETE FROM [VentaidDetalle]  WHERE [idVenta] = @idVenta AND [idDetalleVenta] = @idDetalleVenta", GxErrorMask.GX_NOMASK,prmT000530)
             ,new CursorDef("T000531", "SELECT [descripcionProducto], [precioProducto] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000531,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000532", "SELECT [idVenta], [idDetalleVenta] FROM [VentaidDetalle] WHERE [idVenta] = @idVenta ORDER BY [idVenta], [idDetalleVenta] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000532,11, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 6 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                return;
             case 8 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 16 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
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
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
