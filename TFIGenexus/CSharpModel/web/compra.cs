/*
               File: Compra
        Description: Compra
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:3:6.71
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
   public class compra : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A6idCompra = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_9( A6idCompra) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A2idProveedor = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_8( A2idProveedor) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcompra_iddetalle") == 0 )
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
            gxnrGridcompra_iddetalle_newrow( ) ;
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
            Form.Meta.addItem("description", "Compra", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtidCompra_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public compra( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public compra( IGxContext context )
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
         cmbtipoFacturaCompra = new GXCombobox();
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
         if ( cmbtipoFacturaCompra.ItemCount > 0 )
         {
            A38tipoFacturaCompra = (short)(NumberUtil.Val( cmbtipoFacturaCompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0))), "."));
            AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbtipoFacturaCompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0));
            AssignProp("", false, cmbtipoFacturaCompra_Internalname, "Values", cmbtipoFacturaCompra.ToJavascriptSource(), true);
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Compra", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Compra.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDCOMPRA"+"'), id:'"+"IDCOMPRA"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Compra.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidCompra_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidCompra_Internalname, "Compra", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6idCompra), 4, 0, ".", "")), ((edtidCompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6idCompra), "ZZZ9")) : context.localUtil.Format( (decimal)(A6idCompra), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidCompra_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidCompra_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbtipoFacturaCompra_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, cmbtipoFacturaCompra_Internalname, "Factura Compra", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         /* ComboBox */
         GxWebStd.gx_combobox_ctrl1( context, cmbtipoFacturaCompra, cmbtipoFacturaCompra_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0)), 1, cmbtipoFacturaCompra_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbtipoFacturaCompra.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "", true, "HLP_Compra.htm");
         cmbtipoFacturaCompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0));
         AssignProp("", false, cmbtipoFacturaCompra_Internalname, "Values", (String)(cmbtipoFacturaCompra.ToJavascriptSource()), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtfechaCompra_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtfechaCompra_Internalname, "Compra", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtfechaCompra_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtfechaCompra_Internalname, context.localUtil.Format(A43fechaCompra, "99/99/99"), context.localUtil.Format( A43fechaCompra, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtfechaCompra_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtfechaCompra_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Compra.htm");
         GxWebStd.gx_bitmap( context, edtfechaCompra_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtfechaCompra_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Compra.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtporcentajeIVACompra_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtporcentajeIVACompra_Internalname, "IVACompra", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtporcentajeIVACompra_Internalname, StringUtil.LTrim( StringUtil.NToC( A44porcentajeIVACompra, 4, 2, ".", "")), ((edtporcentajeIVACompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A44porcentajeIVACompra, "9.99")) : context.localUtil.Format( A44porcentajeIVACompra, "9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtporcentajeIVACompra_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtporcentajeIVACompra_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttotalNetoCompra_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttotalNetoCompra_Internalname, "Neto Compra", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edttotalNetoCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( A45totalNetoCompra, 10, 2, ".", "")), ((edttotalNetoCompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A45totalNetoCompra, "ZZZZZZ9.99")) : context.localUtil.Format( A45totalNetoCompra, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttotalNetoCompra_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttotalNetoCompra_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "Precio", "right", false, "", "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edttotalAPagarCompra_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edttotalAPagarCompra_Internalname, "APagar Compra", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edttotalAPagarCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( A46totalAPagarCompra, 10, 2, ".", "")), ((edttotalAPagarCompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A46totalAPagarCompra, "ZZZZZZ9.99")) : context.localUtil.Format( A46totalAPagarCompra, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edttotalAPagarCompra_Jsonclick, 0, "Attribute", "", "", "", "", 1, edttotalAPagarCompra_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "Precio", "right", false, "", "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtidProveedor_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtidProveedor_Internalname, "id Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtidProveedor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2idProveedor), 4, 0, ".", "")), ((edtidProveedor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A2idProveedor), "ZZZ9")) : context.localUtil.Format( (decimal)(A2idProveedor), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtidProveedor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtidProveedor_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Compra.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Compra.htm");
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
         GxWebStd.gx_label_element( context, edtnombreProveedor_Internalname, "nombre Proveedor", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtnombreProveedor_Internalname, A16nombreProveedor, StringUtil.RTrim( context.localUtil.Format( A16nombreProveedor, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtnombreProveedor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtnombreProveedor_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Compra.htm");
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
         GxWebStd.gx_label_ctrl( context, lblTitleiddetalle_Internalname, "id Detalle", "", "", lblTitleiddetalle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridcompra_iddetalle( ) ;
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
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Compra.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridcompra_iddetalle( )
      {
         /*  Grid Control  */
         Gridcompra_iddetalleContainer.AddObjectProperty("GridName", "Gridcompra_iddetalle");
         Gridcompra_iddetalleContainer.AddObjectProperty("Header", subGridcompra_iddetalle_Header);
         Gridcompra_iddetalleContainer.AddObjectProperty("Class", "Grid");
         Gridcompra_iddetalleContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Backcolorstyle), 1, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("CmpContext", "");
         Gridcompra_iddetalleContainer.AddObjectProperty("InMasterPage", "false");
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A47idDetalleCompra), 4, 0, ".", "")));
         Gridcompra_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleCompra_Enabled), 5, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")));
         Gridcompra_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleColumn.AddObjectProperty("Value", A19descripcionProducto);
         Gridcompra_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")));
         Gridcompra_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48cantidadDetalleCompra), 4, 0, ".", "")));
         Gridcompra_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleCompra_Enabled), 5, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcompra_iddetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A49subtotalDetalleCompra, 10, 2, ".", "")));
         Gridcompra_iddetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleCompra_Enabled), 5, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddColumnProperties(Gridcompra_iddetalleColumn);
         Gridcompra_iddetalleContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Selectedindex), 4, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Allowselection), 1, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Selectioncolor), 9, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Allowhovering), 1, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Hoveringcolor), 9, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Allowcollapsing), 1, 0, ".", "")));
         Gridcompra_iddetalleContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcompra_iddetalle_Collapsed), 1, 0, ".", "")));
         nGXsfl_78_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount11 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_11 = 1;
               ScanStart0611( ) ;
               while ( RcdFound11 != 0 )
               {
                  init_level_properties11( ) ;
                  getByPrimaryKey0611( ) ;
                  AddRow0611( ) ;
                  ScanNext0611( ) ;
               }
               ScanEnd0611( ) ;
               nBlankRcdCount11 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B45totalNetoCompra = A45totalNetoCompra;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            standaloneNotModal0611( ) ;
            standaloneModal0611( ) ;
            sMode11 = Gx_mode;
            while ( nGXsfl_78_idx < nRC_GXsfl_78 )
            {
               bGXsfl_78_Refreshing = true;
               ReadRow0611( ) ;
               edtidDetalleCompra_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtidDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtidProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtidProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtdescripcionProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtdescripcionProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdescripcionProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtprecioProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtprecioProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtprecioProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtcantidadDetalleCompra_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDADDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtcantidadDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtcantidadDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               edtsubtotalDetalleCompra_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtsubtotalDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtsubtotalDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
               imgprompt_2_Link = cgiGet( "PROMPT_3_"+sGXsfl_78_idx+"Link");
               if ( ( nRcdExists_11 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0611( ) ;
               }
               SendRow0611( ) ;
               bGXsfl_78_Refreshing = false;
            }
            Gx_mode = sMode11;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            A45totalNetoCompra = B45totalNetoCompra;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount11 = 5;
            nRcdExists_11 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart0611( ) ;
               while ( RcdFound11 != 0 )
               {
                  sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_7811( ) ;
                  init_level_properties11( ) ;
                  standaloneNotModal0611( ) ;
                  getByPrimaryKey0611( ) ;
                  standaloneModal0611( ) ;
                  AddRow0611( ) ;
                  ScanNext0611( ) ;
               }
               ScanEnd0611( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode11 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx+1), 4, 0), 4, "0");
         SubsflControlProps_7811( ) ;
         InitAll0611( ) ;
         init_level_properties11( ) ;
         B45totalNetoCompra = A45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         nRcdExists_11 = 0;
         nIsMod_11 = 0;
         nRcdDeleted_11 = 0;
         nBlankRcdCount11 = (short)(nBlankRcdUsr11+nBlankRcdCount11);
         fRowAdded = 0;
         while ( nBlankRcdCount11 > 0 )
         {
            standaloneNotModal0611( ) ;
            standaloneModal0611( ) ;
            AddRow0611( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtidDetalleCompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount11 = (short)(nBlankRcdCount11-1);
         }
         Gx_mode = sMode11;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         A45totalNetoCompra = B45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridcompra_iddetalleContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcompra_iddetalle", Gridcompra_iddetalleContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcompra_iddetalleContainerData", Gridcompra_iddetalleContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcompra_iddetalleContainerData"+"V", Gridcompra_iddetalleContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcompra_iddetalleContainerData"+"V"+"\" value='"+Gridcompra_iddetalleContainer.GridValuesHidden()+"'/>") ;
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
            Z6idCompra = (short)(context.localUtil.CToN( cgiGet( "Z6idCompra"), ".", ","));
            Z38tipoFacturaCompra = (short)(context.localUtil.CToN( cgiGet( "Z38tipoFacturaCompra"), ".", ","));
            Z43fechaCompra = context.localUtil.CToD( cgiGet( "Z43fechaCompra"), 0);
            Z44porcentajeIVACompra = context.localUtil.CToN( cgiGet( "Z44porcentajeIVACompra"), ".", ",");
            Z2idProveedor = (short)(context.localUtil.CToN( cgiGet( "Z2idProveedor"), ".", ","));
            O45totalNetoCompra = context.localUtil.CToN( cgiGet( "O45totalNetoCompra"), ".", ",");
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            nRC_GXsfl_78 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_78"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtidCompra_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidCompra_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "IDCOMPRA");
               AnyError = 1;
               GX_FocusControl = edtidCompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A6idCompra = 0;
               AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
            }
            else
            {
               A6idCompra = (short)(context.localUtil.CToN( cgiGet( edtidCompra_Internalname), ".", ","));
               AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
            }
            cmbtipoFacturaCompra.Name = cmbtipoFacturaCompra_Internalname;
            cmbtipoFacturaCompra.CurrentValue = cgiGet( cmbtipoFacturaCompra_Internalname);
            A38tipoFacturaCompra = (short)(NumberUtil.Val( cgiGet( cmbtipoFacturaCompra_Internalname), "."));
            AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0));
            if ( context.localUtil.VCDate( cgiGet( edtfechaCompra_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fecha Compra"}), 1, "FECHACOMPRA");
               AnyError = 1;
               GX_FocusControl = edtfechaCompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A43fechaCompra = DateTime.MinValue;
               AssignAttri("", false, "A43fechaCompra", context.localUtil.Format(A43fechaCompra, "99/99/99"));
            }
            else
            {
               A43fechaCompra = context.localUtil.CToD( cgiGet( edtfechaCompra_Internalname), 1);
               AssignAttri("", false, "A43fechaCompra", context.localUtil.Format(A43fechaCompra, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtporcentajeIVACompra_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtporcentajeIVACompra_Internalname), ".", ",") > 0.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PORCENTAJEIVACOMPRA");
               AnyError = 1;
               GX_FocusControl = edtporcentajeIVACompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A44porcentajeIVACompra = 0;
               AssignAttri("", false, "A44porcentajeIVACompra", StringUtil.LTrimStr( A44porcentajeIVACompra, 3, 2));
            }
            else
            {
               A44porcentajeIVACompra = context.localUtil.CToN( cgiGet( edtporcentajeIVACompra_Internalname), ".", ",");
               AssignAttri("", false, "A44porcentajeIVACompra", StringUtil.LTrimStr( A44porcentajeIVACompra, 3, 2));
            }
            A45totalNetoCompra = context.localUtil.CToN( cgiGet( edttotalNetoCompra_Internalname), ".", ",");
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            A46totalAPagarCompra = context.localUtil.CToN( cgiGet( edttotalAPagarCompra_Internalname), ".", ",");
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
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
            A16nombreProveedor = cgiGet( edtnombreProveedor_Internalname);
            AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
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
               A6idCompra = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
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
               InitAll066( ) ;
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
         DisableAttributes066( ) ;
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

      protected void CONFIRM_0611( )
      {
         s45totalNetoCompra = O45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         s46totalAPagarCompra = O46totalAPagarCompra;
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         nGXsfl_78_idx = 0;
         while ( nGXsfl_78_idx < nRC_GXsfl_78 )
         {
            ReadRow0611( ) ;
            if ( ( nRcdExists_11 != 0 ) || ( nIsMod_11 != 0 ) )
            {
               GetKey0611( ) ;
               if ( ( nRcdExists_11 == 0 ) && ( nRcdDeleted_11 == 0 ) )
               {
                  if ( RcdFound11 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0611( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0611( ) ;
                        CloseExtendedTableCursors0611( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                        O45totalNetoCompra = A45totalNetoCompra;
                        n45totalNetoCompra = false;
                        AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                        O46totalAPagarCompra = A46totalAPagarCompra;
                        AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                     }
                  }
                  else
                  {
                     GXCCtl = "IDDETALLECOMPRA_" + sGXsfl_78_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtidDetalleCompra_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound11 != 0 )
                  {
                     if ( nRcdDeleted_11 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0611( ) ;
                        Load0611( ) ;
                        BeforeValidate0611( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0611( ) ;
                           O45totalNetoCompra = A45totalNetoCompra;
                           n45totalNetoCompra = false;
                           AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                           O46totalAPagarCompra = A46totalAPagarCompra;
                           AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                        }
                     }
                     else
                     {
                        if ( nIsMod_11 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0611( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0611( ) ;
                              CloseExtendedTableCursors0611( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                              O45totalNetoCompra = A45totalNetoCompra;
                              n45totalNetoCompra = false;
                              AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                              O46totalAPagarCompra = A46totalAPagarCompra;
                              AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_11 == 0 )
                     {
                        GXCCtl = "IDDETALLECOMPRA_" + sGXsfl_78_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtidDetalleCompra_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtidDetalleCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A47idDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( edtidProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( edtdescripcionProducto_Internalname, A19descripcionProducto) ;
            ChangePostValue( edtprecioProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", ""))) ;
            ChangePostValue( edtcantidadDetalleCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48cantidadDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( edtsubtotalDetalleCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( A49subtotalDetalleCompra, 10, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z47idDetalleCompra_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z47idDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z48cantidadDetalleCompra_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48cantidadDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( "T49subtotalDetalleCompra_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( O49subtotalDetalleCompra, 10, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_11_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_11_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_11_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", ""))) ;
            if ( nIsMod_11 != 0 )
            {
               ChangePostValue( "IDDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleCompra_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDADDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleCompra_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleCompra_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O45totalNetoCompra = s45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         O46totalAPagarCompra = s46totalAPagarCompra;
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption060( )
      {
      }

      protected void ZM066( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z38tipoFacturaCompra = T00066_A38tipoFacturaCompra[0];
               Z43fechaCompra = T00066_A43fechaCompra[0];
               Z44porcentajeIVACompra = T00066_A44porcentajeIVACompra[0];
               Z2idProveedor = T00066_A2idProveedor[0];
            }
            else
            {
               Z38tipoFacturaCompra = A38tipoFacturaCompra;
               Z43fechaCompra = A43fechaCompra;
               Z44porcentajeIVACompra = A44porcentajeIVACompra;
               Z2idProveedor = A2idProveedor;
            }
         }
         if ( GX_JID == -7 )
         {
            Z6idCompra = A6idCompra;
            Z38tipoFacturaCompra = A38tipoFacturaCompra;
            Z43fechaCompra = A43fechaCompra;
            Z44porcentajeIVACompra = A44porcentajeIVACompra;
            Z2idProveedor = A2idProveedor;
            Z45totalNetoCompra = A45totalNetoCompra;
            Z16nombreProveedor = A16nombreProveedor;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPROVEEDOR"+"'), id:'"+"IDPROVEEDOR"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load066( )
      {
         /* Using cursor T000611 */
         pr_default.execute(7, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound6 = 1;
            A38tipoFacturaCompra = T000611_A38tipoFacturaCompra[0];
            AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0));
            A43fechaCompra = T000611_A43fechaCompra[0];
            AssignAttri("", false, "A43fechaCompra", context.localUtil.Format(A43fechaCompra, "99/99/99"));
            A44porcentajeIVACompra = T000611_A44porcentajeIVACompra[0];
            AssignAttri("", false, "A44porcentajeIVACompra", StringUtil.LTrimStr( A44porcentajeIVACompra, 3, 2));
            A16nombreProveedor = T000611_A16nombreProveedor[0];
            AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
            A2idProveedor = T000611_A2idProveedor[0];
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            A45totalNetoCompra = T000611_A45totalNetoCompra[0];
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            n45totalNetoCompra = T000611_n45totalNetoCompra[0];
            ZM066( -7) ;
         }
         pr_default.close(7);
         OnLoadActions066( ) ;
      }

      protected void OnLoadActions066( )
      {
         O45totalNetoCompra = A45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         A46totalAPagarCompra = (decimal)(A45totalNetoCompra+(A45totalNetoCompra*A44porcentajeIVACompra)/ (decimal)(100));
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
      }

      protected void CheckExtendedTable066( )
      {
         nIsDirty_6 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00069 */
         pr_default.execute(6, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(6) != 101) )
         {
            A45totalNetoCompra = T00069_A45totalNetoCompra[0];
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            n45totalNetoCompra = T00069_n45totalNetoCompra[0];
         }
         else
         {
            nIsDirty_6 = 1;
            A45totalNetoCompra = 0;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         }
         pr_default.close(6);
         nIsDirty_6 = 1;
         A46totalAPagarCompra = (decimal)(A45totalNetoCompra+(A45totalNetoCompra*A44porcentajeIVACompra)/ (decimal)(100));
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         if ( ! ( ( A38tipoFacturaCompra == 0 ) || ( A38tipoFacturaCompra == 1 ) || ( A38tipoFacturaCompra == 2 ) ) )
         {
            GX_msglist.addItem("Field tipo Factura Compra is out of range", "OutOfRange", 1, "TIPOFACTURACOMPRA");
            AnyError = 1;
            GX_FocusControl = cmbtipoFacturaCompra_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A43fechaCompra) || ( A43fechaCompra >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field fecha Compra is out of range", "OutOfRange", 1, "FECHACOMPRA");
            AnyError = 1;
            GX_FocusControl = edtfechaCompra_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Proveedor'.", "ForeignKeyNotFound", 1, "IDPROVEEDOR");
            AnyError = 1;
            GX_FocusControl = edtidProveedor_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A16nombreProveedor = T00067_A16nombreProveedor[0];
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors066( )
      {
         pr_default.close(6);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_9( short A6idCompra )
      {
         /* Using cursor T000613 */
         pr_default.execute(8, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A45totalNetoCompra = T000613_A45totalNetoCompra[0];
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            n45totalNetoCompra = T000613_n45totalNetoCompra[0];
         }
         else
         {
            A45totalNetoCompra = 0;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A45totalNetoCompra, 10, 2, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(8) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(8);
      }

      protected void gxLoad_8( short A2idProveedor )
      {
         /* Using cursor T000614 */
         pr_default.execute(9, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Proveedor'.", "ForeignKeyNotFound", 1, "IDPROVEEDOR");
            AnyError = 1;
            GX_FocusControl = edtidProveedor_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A16nombreProveedor = T000614_A16nombreProveedor[0];
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( A16nombreProveedor)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(9) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(9);
      }

      protected void GetKey066( )
      {
         /* Using cursor T000615 */
         pr_default.execute(10, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM066( 7) ;
            RcdFound6 = 1;
            A6idCompra = T00066_A6idCompra[0];
            AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
            A38tipoFacturaCompra = T00066_A38tipoFacturaCompra[0];
            AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0));
            A43fechaCompra = T00066_A43fechaCompra[0];
            AssignAttri("", false, "A43fechaCompra", context.localUtil.Format(A43fechaCompra, "99/99/99"));
            A44porcentajeIVACompra = T00066_A44porcentajeIVACompra[0];
            AssignAttri("", false, "A44porcentajeIVACompra", StringUtil.LTrimStr( A44porcentajeIVACompra, 3, 2));
            A2idProveedor = T00066_A2idProveedor[0];
            AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
            Z6idCompra = A6idCompra;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load066( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey066( ) ;
            }
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey066( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey066( ) ;
         if ( RcdFound6 == 0 )
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
         RcdFound6 = 0;
         /* Using cursor T000616 */
         pr_default.execute(11, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000616_A6idCompra[0] < A6idCompra ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000616_A6idCompra[0] > A6idCompra ) ) )
            {
               A6idCompra = T000616_A6idCompra[0];
               AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
               RcdFound6 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T000617 */
         pr_default.execute(12, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000617_A6idCompra[0] > A6idCompra ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000617_A6idCompra[0] < A6idCompra ) ) )
            {
               A6idCompra = T000617_A6idCompra[0];
               AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
               RcdFound6 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey066( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            A45totalNetoCompra = O45totalNetoCompra;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            A46totalAPagarCompra = O46totalAPagarCompra;
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
            GX_FocusControl = edtidCompra_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert066( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A6idCompra != Z6idCompra )
               {
                  A6idCompra = Z6idCompra;
                  AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "IDCOMPRA");
                  AnyError = 1;
                  GX_FocusControl = edtidCompra_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  A45totalNetoCompra = O45totalNetoCompra;
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                  A46totalAPagarCompra = O46totalAPagarCompra;
                  AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtidCompra_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  A45totalNetoCompra = O45totalNetoCompra;
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                  A46totalAPagarCompra = O46totalAPagarCompra;
                  AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                  Update066( ) ;
                  GX_FocusControl = edtidCompra_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A6idCompra != Z6idCompra )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  A45totalNetoCompra = O45totalNetoCompra;
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                  A46totalAPagarCompra = O46totalAPagarCompra;
                  AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                  GX_FocusControl = edtidCompra_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert066( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "IDCOMPRA");
                     AnyError = 1;
                     GX_FocusControl = edtidCompra_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     A45totalNetoCompra = O45totalNetoCompra;
                     n45totalNetoCompra = false;
                     AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                     A46totalAPagarCompra = O46totalAPagarCompra;
                     AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                     GX_FocusControl = edtidCompra_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert066( ) ;
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
         if ( A6idCompra != Z6idCompra )
         {
            A6idCompra = Z6idCompra;
            AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "IDCOMPRA");
            AnyError = 1;
            GX_FocusControl = edtidCompra_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A45totalNetoCompra = O45totalNetoCompra;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            A46totalAPagarCompra = O46totalAPagarCompra;
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtidCompra_Internalname;
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
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "IDCOMPRA");
            AnyError = 1;
            GX_FocusControl = edtidCompra_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = cmbtipoFacturaCompra_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaCompra_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd066( ) ;
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
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaCompra_Internalname;
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
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaCompra_Internalname;
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
         ScanStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound6 != 0 )
            {
               ScanNext066( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbtipoFacturaCompra_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd066( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency066( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00065 */
            pr_default.execute(3, new Object[] {A6idCompra});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Compra"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z38tipoFacturaCompra != T00065_A38tipoFacturaCompra[0] ) || ( Z43fechaCompra != T00065_A43fechaCompra[0] ) || ( Z44porcentajeIVACompra != T00065_A44porcentajeIVACompra[0] ) || ( Z2idProveedor != T00065_A2idProveedor[0] ) )
            {
               if ( Z38tipoFacturaCompra != T00065_A38tipoFacturaCompra[0] )
               {
                  GXUtil.WriteLog("compra:[seudo value changed for attri]"+"tipoFacturaCompra");
                  GXUtil.WriteLogRaw("Old: ",Z38tipoFacturaCompra);
                  GXUtil.WriteLogRaw("Current: ",T00065_A38tipoFacturaCompra[0]);
               }
               if ( Z43fechaCompra != T00065_A43fechaCompra[0] )
               {
                  GXUtil.WriteLog("compra:[seudo value changed for attri]"+"fechaCompra");
                  GXUtil.WriteLogRaw("Old: ",Z43fechaCompra);
                  GXUtil.WriteLogRaw("Current: ",T00065_A43fechaCompra[0]);
               }
               if ( Z44porcentajeIVACompra != T00065_A44porcentajeIVACompra[0] )
               {
                  GXUtil.WriteLog("compra:[seudo value changed for attri]"+"porcentajeIVACompra");
                  GXUtil.WriteLogRaw("Old: ",Z44porcentajeIVACompra);
                  GXUtil.WriteLogRaw("Current: ",T00065_A44porcentajeIVACompra[0]);
               }
               if ( Z2idProveedor != T00065_A2idProveedor[0] )
               {
                  GXUtil.WriteLog("compra:[seudo value changed for attri]"+"idProveedor");
                  GXUtil.WriteLogRaw("Old: ",Z2idProveedor);
                  GXUtil.WriteLogRaw("Current: ",T00065_A2idProveedor[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Compra"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM066( 0) ;
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000618 */
                     pr_default.execute(13, new Object[] {A6idCompra, A38tipoFacturaCompra, A43fechaCompra, A44porcentajeIVACompra, A2idProveedor});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Compra") ;
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
                           ProcessLevel066( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption060( ) ;
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
               Load066( ) ;
            }
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void Update066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000619 */
                     pr_default.execute(14, new Object[] {A38tipoFacturaCompra, A43fechaCompra, A44porcentajeIVACompra, A2idProveedor, A6idCompra});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Compra") ;
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Compra"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate066( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel066( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption060( ) ;
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
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void DeferredUpdate066( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls066( ) ;
            AfterConfirm066( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete066( ) ;
               if ( AnyError == 0 )
               {
                  A45totalNetoCompra = O45totalNetoCompra;
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                  A46totalAPagarCompra = O46totalAPagarCompra;
                  AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                  ScanStart0611( ) ;
                  while ( RcdFound11 != 0 )
                  {
                     getByPrimaryKey0611( ) ;
                     Delete0611( ) ;
                     ScanNext0611( ) ;
                     O45totalNetoCompra = A45totalNetoCompra;
                     n45totalNetoCompra = false;
                     AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                     O46totalAPagarCompra = A46totalAPagarCompra;
                     AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
                  }
                  ScanEnd0611( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000620 */
                     pr_default.execute(15, new Object[] {A6idCompra});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("Compra") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound6 == 0 )
                           {
                              InitAll066( ) ;
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
                           ResetCaption060( ) ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel066( ) ;
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls066( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000622 */
            pr_default.execute(16, new Object[] {A6idCompra});
            if ( (pr_default.getStatus(16) != 101) )
            {
               A45totalNetoCompra = T000622_A45totalNetoCompra[0];
               AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
               n45totalNetoCompra = T000622_n45totalNetoCompra[0];
            }
            else
            {
               A45totalNetoCompra = 0;
               n45totalNetoCompra = false;
               AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            }
            pr_default.close(16);
            A46totalAPagarCompra = (decimal)(A45totalNetoCompra+(A45totalNetoCompra*A44porcentajeIVACompra)/ (decimal)(100));
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
            /* Using cursor T000623 */
            pr_default.execute(17, new Object[] {A2idProveedor});
            A16nombreProveedor = T000623_A16nombreProveedor[0];
            AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
            pr_default.close(17);
         }
      }

      protected void ProcessNestedLevel0611( )
      {
         s45totalNetoCompra = O45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         s46totalAPagarCompra = O46totalAPagarCompra;
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         nGXsfl_78_idx = 0;
         while ( nGXsfl_78_idx < nRC_GXsfl_78 )
         {
            ReadRow0611( ) ;
            if ( ( nRcdExists_11 != 0 ) || ( nIsMod_11 != 0 ) )
            {
               standaloneNotModal0611( ) ;
               GetKey0611( ) ;
               if ( ( nRcdExists_11 == 0 ) && ( nRcdDeleted_11 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert0611( ) ;
               }
               else
               {
                  if ( RcdFound11 != 0 )
                  {
                     if ( ( nRcdDeleted_11 != 0 ) && ( nRcdExists_11 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete0611( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_11 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update0611( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_11 == 0 )
                     {
                        GXCCtl = "IDDETALLECOMPRA_" + sGXsfl_78_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtidDetalleCompra_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O45totalNetoCompra = A45totalNetoCompra;
               n45totalNetoCompra = false;
               AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
               O46totalAPagarCompra = A46totalAPagarCompra;
               AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
            }
            ChangePostValue( edtidDetalleCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A47idDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( edtidProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( edtdescripcionProducto_Internalname, A19descripcionProducto) ;
            ChangePostValue( edtprecioProducto_Internalname, StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", ""))) ;
            ChangePostValue( edtcantidadDetalleCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48cantidadDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( edtsubtotalDetalleCompra_Internalname, StringUtil.LTrim( StringUtil.NToC( A49subtotalDetalleCompra, 10, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z47idDetalleCompra_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z47idDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z48cantidadDetalleCompra_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48cantidadDetalleCompra), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", ""))) ;
            ChangePostValue( "T49subtotalDetalleCompra_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( O49subtotalDetalleCompra, 10, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_11_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_11_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_11_"+sGXsfl_78_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", ""))) ;
            if ( nIsMod_11 != 0 )
            {
               ChangePostValue( "IDDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleCompra_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDADDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleCompra_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleCompra_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0611( ) ;
         if ( AnyError != 0 )
         {
            O45totalNetoCompra = s45totalNetoCompra;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            O46totalAPagarCompra = s46totalAPagarCompra;
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         }
         nRcdExists_11 = 0;
         nIsMod_11 = 0;
         nRcdDeleted_11 = 0;
      }

      protected void ProcessLevel066( )
      {
         /* Save parent mode. */
         sMode6 = Gx_mode;
         ProcessNestedLevel0611( ) ;
         if ( AnyError != 0 )
         {
            O45totalNetoCompra = s45totalNetoCompra;
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            O46totalAPagarCompra = s46totalAPagarCompra;
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         }
         /* Restore parent mode. */
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel066( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete066( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(16);
            pr_default.close(2);
            context.CommitDataStores("compra",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
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
            context.RollbackDataStores("compra",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart066( )
      {
         /* Using cursor T000624 */
         pr_default.execute(18);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound6 = 1;
            A6idCompra = T000624_A6idCompra[0];
            AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext066( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound6 = 1;
            A6idCompra = T000624_A6idCompra[0];
            AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
         }
      }

      protected void ScanEnd066( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm066( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert066( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate066( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete066( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete066( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate066( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes066( )
      {
         edtidCompra_Enabled = 0;
         AssignProp("", false, edtidCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidCompra_Enabled), 5, 0), true);
         cmbtipoFacturaCompra.Enabled = 0;
         AssignProp("", false, cmbtipoFacturaCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbtipoFacturaCompra.Enabled), 5, 0), true);
         edtfechaCompra_Enabled = 0;
         AssignProp("", false, edtfechaCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtfechaCompra_Enabled), 5, 0), true);
         edtporcentajeIVACompra_Enabled = 0;
         AssignProp("", false, edtporcentajeIVACompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtporcentajeIVACompra_Enabled), 5, 0), true);
         edttotalNetoCompra_Enabled = 0;
         AssignProp("", false, edttotalNetoCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttotalNetoCompra_Enabled), 5, 0), true);
         edttotalAPagarCompra_Enabled = 0;
         AssignProp("", false, edttotalAPagarCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edttotalAPagarCompra_Enabled), 5, 0), true);
         edtidProveedor_Enabled = 0;
         AssignProp("", false, edtidProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProveedor_Enabled), 5, 0), true);
         edtnombreProveedor_Enabled = 0;
         AssignProp("", false, edtnombreProveedor_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtnombreProveedor_Enabled), 5, 0), true);
      }

      protected void ZM0611( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z48cantidadDetalleCompra = T00063_A48cantidadDetalleCompra[0];
               Z3idProducto = T00063_A3idProducto[0];
            }
            else
            {
               Z48cantidadDetalleCompra = A48cantidadDetalleCompra;
               Z3idProducto = A3idProducto;
            }
         }
         if ( GX_JID == -10 )
         {
            Z6idCompra = A6idCompra;
            Z47idDetalleCompra = A47idDetalleCompra;
            Z48cantidadDetalleCompra = A48cantidadDetalleCompra;
            Z3idProducto = A3idProducto;
            Z19descripcionProducto = A19descripcionProducto;
            Z21precioProducto = A21precioProducto;
         }
      }

      protected void standaloneNotModal0611( )
      {
      }

      protected void standaloneModal0611( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtidDetalleCompra_Enabled = 0;
            AssignProp("", false, edtidDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         }
         else
         {
            edtidDetalleCompra_Enabled = 1;
            AssignProp("", false, edtidDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         }
      }

      protected void Load0611( )
      {
         /* Using cursor T000625 */
         pr_default.execute(19, new Object[] {A6idCompra, A47idDetalleCompra});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound11 = 1;
            A19descripcionProducto = T000625_A19descripcionProducto[0];
            A21precioProducto = T000625_A21precioProducto[0];
            A48cantidadDetalleCompra = T000625_A48cantidadDetalleCompra[0];
            A3idProducto = T000625_A3idProducto[0];
            ZM0611( -10) ;
         }
         pr_default.close(19);
         OnLoadActions0611( ) ;
      }

      protected void OnLoadActions0611( )
      {
         A49subtotalDetalleCompra = (decimal)(A21precioProducto*A48cantidadDetalleCompra);
         O49subtotalDetalleCompra = A49subtotalDetalleCompra;
         if ( IsIns( )  )
         {
            A45totalNetoCompra = (decimal)(O45totalNetoCompra+A49subtotalDetalleCompra);
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         }
         else
         {
            if ( IsUpd( )  )
            {
               A45totalNetoCompra = (decimal)(O45totalNetoCompra+A49subtotalDetalleCompra-O49subtotalDetalleCompra);
               n45totalNetoCompra = false;
               AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            }
            else
            {
               if ( IsDlt( )  )
               {
                  A45totalNetoCompra = (decimal)(O45totalNetoCompra-O49subtotalDetalleCompra);
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
               }
            }
         }
         A46totalAPagarCompra = (decimal)(A45totalNetoCompra+(A45totalNetoCompra*A44porcentajeIVACompra)/ (decimal)(100));
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
      }

      protected void CheckExtendedTable0611( )
      {
         nIsDirty_11 = 0;
         Gx_BScreen = 1;
         standaloneModal0611( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "IDPRODUCTO_" + sGXsfl_78_idx;
            GX_msglist.addItem("No matching 'Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A19descripcionProducto = T00064_A19descripcionProducto[0];
         A21precioProducto = T00064_A21precioProducto[0];
         pr_default.close(2);
         nIsDirty_11 = 1;
         A49subtotalDetalleCompra = (decimal)(A21precioProducto*A48cantidadDetalleCompra);
         if ( IsIns( )  )
         {
            nIsDirty_11 = 1;
            A45totalNetoCompra = (decimal)(O45totalNetoCompra+A49subtotalDetalleCompra);
            n45totalNetoCompra = false;
            AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         }
         else
         {
            if ( IsUpd( )  )
            {
               nIsDirty_11 = 1;
               A45totalNetoCompra = (decimal)(O45totalNetoCompra+A49subtotalDetalleCompra-O49subtotalDetalleCompra);
               n45totalNetoCompra = false;
               AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            }
            else
            {
               if ( IsDlt( )  )
               {
                  nIsDirty_11 = 1;
                  A45totalNetoCompra = (decimal)(O45totalNetoCompra-O49subtotalDetalleCompra);
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
               }
            }
         }
         nIsDirty_11 = 1;
         A46totalAPagarCompra = (decimal)(A45totalNetoCompra+(A45totalNetoCompra*A44porcentajeIVACompra)/ (decimal)(100));
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
      }

      protected void CloseExtendedTableCursors0611( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0611( )
      {
      }

      protected void gxLoad_11( short A3idProducto )
      {
         /* Using cursor T000626 */
         pr_default.execute(20, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GXCCtl = "IDPRODUCTO_" + sGXsfl_78_idx;
            GX_msglist.addItem("No matching 'Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A19descripcionProducto = T000626_A19descripcionProducto[0];
         A21precioProducto = T000626_A21precioProducto[0];
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

      protected void GetKey0611( )
      {
         /* Using cursor T000627 */
         pr_default.execute(21, new Object[] {A6idCompra, A47idDetalleCompra});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey0611( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A6idCompra, A47idDetalleCompra});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0611( 10) ;
            RcdFound11 = 1;
            InitializeNonKey0611( ) ;
            A47idDetalleCompra = T00063_A47idDetalleCompra[0];
            A48cantidadDetalleCompra = T00063_A48cantidadDetalleCompra[0];
            A3idProducto = T00063_A3idProducto[0];
            Z6idCompra = A6idCompra;
            Z47idDetalleCompra = A47idDetalleCompra;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0611( ) ;
            Load0611( ) ;
            Gx_mode = sMode11;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0611( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal0611( ) ;
            Gx_mode = sMode11;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes0611( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0611( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A6idCompra, A47idDetalleCompra});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CompraidDetalle"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z48cantidadDetalleCompra != T00062_A48cantidadDetalleCompra[0] ) || ( Z3idProducto != T00062_A3idProducto[0] ) )
            {
               if ( Z48cantidadDetalleCompra != T00062_A48cantidadDetalleCompra[0] )
               {
                  GXUtil.WriteLog("compra:[seudo value changed for attri]"+"cantidadDetalleCompra");
                  GXUtil.WriteLogRaw("Old: ",Z48cantidadDetalleCompra);
                  GXUtil.WriteLogRaw("Current: ",T00062_A48cantidadDetalleCompra[0]);
               }
               if ( Z3idProducto != T00062_A3idProducto[0] )
               {
                  GXUtil.WriteLog("compra:[seudo value changed for attri]"+"idProducto");
                  GXUtil.WriteLogRaw("Old: ",Z3idProducto);
                  GXUtil.WriteLogRaw("Current: ",T00062_A3idProducto[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CompraidDetalle"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0611( )
      {
         BeforeValidate0611( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0611( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0611( 0) ;
            CheckOptimisticConcurrency0611( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0611( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0611( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000628 */
                     pr_default.execute(22, new Object[] {A6idCompra, A47idDetalleCompra, A48cantidadDetalleCompra, A3idProducto});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("CompraidDetalle") ;
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
               Load0611( ) ;
            }
            EndLevel0611( ) ;
         }
         CloseExtendedTableCursors0611( ) ;
      }

      protected void Update0611( )
      {
         BeforeValidate0611( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0611( ) ;
         }
         if ( ( nIsMod_11 != 0 ) || ( nIsDirty_11 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency0611( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm0611( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate0611( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000629 */
                        pr_default.execute(23, new Object[] {A48cantidadDetalleCompra, A3idProducto, A6idCompra, A47idDetalleCompra});
                        pr_default.close(23);
                        dsDefault.SmartCacheProvider.SetUpdated("CompraidDetalle") ;
                        if ( (pr_default.getStatus(23) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CompraidDetalle"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate0611( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey0611( ) ;
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
               EndLevel0611( ) ;
            }
         }
         CloseExtendedTableCursors0611( ) ;
      }

      protected void DeferredUpdate0611( )
      {
      }

      protected void Delete0611( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0611( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0611( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0611( ) ;
            AfterConfirm0611( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0611( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000630 */
                  pr_default.execute(24, new Object[] {A6idCompra, A47idDetalleCompra});
                  pr_default.close(24);
                  dsDefault.SmartCacheProvider.SetUpdated("CompraidDetalle") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel0611( ) ;
         Gx_mode = sMode11;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0611( )
      {
         standaloneModal0611( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000631 */
            pr_default.execute(25, new Object[] {A3idProducto});
            A19descripcionProducto = T000631_A19descripcionProducto[0];
            A21precioProducto = T000631_A21precioProducto[0];
            pr_default.close(25);
            A49subtotalDetalleCompra = (decimal)(A21precioProducto*A48cantidadDetalleCompra);
            if ( IsIns( )  )
            {
               A45totalNetoCompra = (decimal)(O45totalNetoCompra+A49subtotalDetalleCompra);
               n45totalNetoCompra = false;
               AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
            }
            else
            {
               if ( IsUpd( )  )
               {
                  A45totalNetoCompra = (decimal)(O45totalNetoCompra+A49subtotalDetalleCompra-O49subtotalDetalleCompra);
                  n45totalNetoCompra = false;
                  AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
               }
               else
               {
                  if ( IsDlt( )  )
                  {
                     A45totalNetoCompra = (decimal)(O45totalNetoCompra-O49subtotalDetalleCompra);
                     n45totalNetoCompra = false;
                     AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
                  }
               }
            }
            A46totalAPagarCompra = (decimal)(A45totalNetoCompra+(A45totalNetoCompra*A44porcentajeIVACompra)/ (decimal)(100));
            AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         }
      }

      protected void EndLevel0611( )
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

      public void ScanStart0611( )
      {
         /* Scan By routine */
         /* Using cursor T000632 */
         pr_default.execute(26, new Object[] {A6idCompra});
         RcdFound11 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound11 = 1;
            A47idDetalleCompra = T000632_A47idDetalleCompra[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0611( )
      {
         /* Scan next routine */
         pr_default.readNext(26);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound11 = 1;
            A47idDetalleCompra = T000632_A47idDetalleCompra[0];
         }
      }

      protected void ScanEnd0611( )
      {
         pr_default.close(26);
      }

      protected void AfterConfirm0611( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0611( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0611( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0611( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0611( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0611( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0611( )
      {
         edtidDetalleCompra_Enabled = 0;
         AssignProp("", false, edtidDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtidProducto_Enabled = 0;
         AssignProp("", false, edtidProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtdescripcionProducto_Enabled = 0;
         AssignProp("", false, edtdescripcionProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtdescripcionProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtprecioProducto_Enabled = 0;
         AssignProp("", false, edtprecioProducto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtprecioProducto_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtcantidadDetalleCompra_Enabled = 0;
         AssignProp("", false, edtcantidadDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtcantidadDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
         edtsubtotalDetalleCompra_Enabled = 0;
         AssignProp("", false, edtsubtotalDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtsubtotalDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
      }

      protected void send_integrity_lvl_hashes0611( )
      {
      }

      protected void send_integrity_lvl_hashes066( )
      {
      }

      protected void SubsflControlProps_7811( )
      {
         edtidDetalleCompra_Internalname = "IDDETALLECOMPRA_"+sGXsfl_78_idx;
         edtidProducto_Internalname = "IDPRODUCTO_"+sGXsfl_78_idx;
         imgprompt_3_Internalname = "PROMPT_3_"+sGXsfl_78_idx;
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx;
         edtprecioProducto_Internalname = "PRECIOPRODUCTO_"+sGXsfl_78_idx;
         edtcantidadDetalleCompra_Internalname = "CANTIDADDETALLECOMPRA_"+sGXsfl_78_idx;
         edtsubtotalDetalleCompra_Internalname = "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_idx;
      }

      protected void SubsflControlProps_fel_7811( )
      {
         edtidDetalleCompra_Internalname = "IDDETALLECOMPRA_"+sGXsfl_78_fel_idx;
         edtidProducto_Internalname = "IDPRODUCTO_"+sGXsfl_78_fel_idx;
         imgprompt_3_Internalname = "PROMPT_3_"+sGXsfl_78_fel_idx;
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO_"+sGXsfl_78_fel_idx;
         edtprecioProducto_Internalname = "PRECIOPRODUCTO_"+sGXsfl_78_fel_idx;
         edtcantidadDetalleCompra_Internalname = "CANTIDADDETALLECOMPRA_"+sGXsfl_78_fel_idx;
         edtsubtotalDetalleCompra_Internalname = "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_fel_idx;
      }

      protected void AddRow0611( )
      {
         nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
         SubsflControlProps_7811( ) ;
         SendRow0611( ) ;
      }

      protected void SendRow0611( )
      {
         Gridcompra_iddetalleRow = GXWebRow.GetNew(context);
         if ( subGridcompra_iddetalle_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcompra_iddetalle_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridcompra_iddetalle_Class, "") != 0 )
            {
               subGridcompra_iddetalle_Linesclass = subGridcompra_iddetalle_Class+"Odd";
            }
         }
         else if ( subGridcompra_iddetalle_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcompra_iddetalle_Backstyle = 0;
            subGridcompra_iddetalle_Backcolor = subGridcompra_iddetalle_Allbackcolor;
            if ( StringUtil.StrCmp(subGridcompra_iddetalle_Class, "") != 0 )
            {
               subGridcompra_iddetalle_Linesclass = subGridcompra_iddetalle_Class+"Uniform";
            }
         }
         else if ( subGridcompra_iddetalle_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcompra_iddetalle_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridcompra_iddetalle_Class, "") != 0 )
            {
               subGridcompra_iddetalle_Linesclass = subGridcompra_iddetalle_Class+"Odd";
            }
            subGridcompra_iddetalle_Backcolor = (int)(0x0);
         }
         else if ( subGridcompra_iddetalle_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcompra_iddetalle_Backstyle = 1;
            if ( ((int)((nGXsfl_78_idx) % (2))) == 0 )
            {
               subGridcompra_iddetalle_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcompra_iddetalle_Class, "") != 0 )
               {
                  subGridcompra_iddetalle_Linesclass = subGridcompra_iddetalle_Class+"Even";
               }
            }
            else
            {
               subGridcompra_iddetalle_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcompra_iddetalle_Class, "") != 0 )
               {
                  subGridcompra_iddetalle_Linesclass = subGridcompra_iddetalle_Class+"Odd";
               }
            }
         }
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"IDPRODUCTO_"+sGXsfl_78_idx+"'), id:'"+"IDPRODUCTO_"+sGXsfl_78_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_11_"+sGXsfl_78_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_78_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_78_idx + "',78)\"";
         ROClassString = "Attribute";
         Gridcompra_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidDetalleCompra_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A47idDetalleCompra), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A47idDetalleCompra), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,79);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidDetalleCompra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtidDetalleCompra_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_78_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_78_idx + "',78)\"";
         ROClassString = "Attribute";
         Gridcompra_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")),((edtidProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9")) : context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,80);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtidProducto_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         Gridcompra_iddetalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_3_Internalname,(String)sImgUrl,(String)imgprompt_3_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_3_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridcompra_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdescripcionProducto_Internalname,(String)A19descripcionProducto,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdescripcionProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdescripcionProducto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridcompra_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprecioProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")),((edtprecioProducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99")) : context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprecioProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtprecioProducto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Precio",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_78_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_78_idx + "',78)\"";
         ROClassString = "Attribute";
         Gridcompra_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantidadDetalleCompra_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A48cantidadDetalleCompra), 4, 0, ".", "")),((edtcantidadDetalleCompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A48cantidadDetalleCompra), "ZZZ9")) : context.localUtil.Format( (decimal)(A48cantidadDetalleCompra), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,83);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantidadDetalleCompra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcantidadDetalleCompra_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridcompra_iddetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubtotalDetalleCompra_Internalname,StringUtil.LTrim( StringUtil.NToC( A49subtotalDetalleCompra, 10, 2, ".", "")),((edtsubtotalDetalleCompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A49subtotalDetalleCompra, "ZZZZZZ9.99")) : context.localUtil.Format( A49subtotalDetalleCompra, "ZZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubtotalDetalleCompra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubtotalDetalleCompra_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)78,(short)1,(short)-1,(short)0,(bool)true,(String)"Precio",(String)"right",(bool)false,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcompra_iddetalleRow);
         send_integrity_lvl_hashes0611( ) ;
         GXCCtl = "Z47idDetalleCompra_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z47idDetalleCompra), 4, 0, ".", "")));
         GXCCtl = "Z48cantidadDetalleCompra_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48cantidadDetalleCompra), 4, 0, ".", "")));
         GXCCtl = "Z3idProducto_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3idProducto), 4, 0, ".", "")));
         GXCCtl = "O49subtotalDetalleCompra_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O49subtotalDetalleCompra, 10, 2, ".", "")));
         GXCCtl = "nRcdDeleted_11_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_11_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", "")));
         GXCCtl = "nIsMod_11_" + sGXsfl_78_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IDDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidDetalleCompra_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtidProducto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdescripcionProducto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprecioProducto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CANTIDADDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidadDetalleCompra_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubtotalDetalleCompra_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_3_"+sGXsfl_78_idx+"Link", StringUtil.RTrim( imgprompt_3_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcompra_iddetalleContainer.AddRow(Gridcompra_iddetalleRow);
      }

      protected void ReadRow0611( )
      {
         nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
         SubsflControlProps_7811( ) ;
         edtidDetalleCompra_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtidProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "IDPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtdescripcionProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "DESCRIPCIONPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtprecioProducto_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRECIOPRODUCTO_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtcantidadDetalleCompra_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDADDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         edtsubtotalDetalleCompra_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBTOTALDETALLECOMPRA_"+sGXsfl_78_idx+"Enabled"), ".", ","));
         imgprompt_2_Link = cgiGet( "PROMPT_3_"+sGXsfl_78_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtidDetalleCompra_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtidDetalleCompra_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "IDDETALLECOMPRA_" + sGXsfl_78_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtidDetalleCompra_Internalname;
            wbErr = true;
            A47idDetalleCompra = 0;
         }
         else
         {
            A47idDetalleCompra = (short)(context.localUtil.CToN( cgiGet( edtidDetalleCompra_Internalname), ".", ","));
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
         if ( ( ( context.localUtil.CToN( cgiGet( edtcantidadDetalleCompra_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantidadDetalleCompra_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CANTIDADDETALLECOMPRA_" + sGXsfl_78_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcantidadDetalleCompra_Internalname;
            wbErr = true;
            A48cantidadDetalleCompra = 0;
         }
         else
         {
            A48cantidadDetalleCompra = (short)(context.localUtil.CToN( cgiGet( edtcantidadDetalleCompra_Internalname), ".", ","));
         }
         A49subtotalDetalleCompra = context.localUtil.CToN( cgiGet( edtsubtotalDetalleCompra_Internalname), ".", ",");
         GXCCtl = "Z47idDetalleCompra_" + sGXsfl_78_idx;
         Z47idDetalleCompra = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z48cantidadDetalleCompra_" + sGXsfl_78_idx;
         Z48cantidadDetalleCompra = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z3idProducto_" + sGXsfl_78_idx;
         Z3idProducto = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "O49subtotalDetalleCompra_" + sGXsfl_78_idx;
         O49subtotalDetalleCompra = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",");
         GXCCtl = "nRcdDeleted_11_" + sGXsfl_78_idx;
         nRcdDeleted_11 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_11_" + sGXsfl_78_idx;
         nRcdExists_11 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_11_" + sGXsfl_78_idx;
         nIsMod_11 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtidDetalleCompra_Enabled = edtidDetalleCompra_Enabled;
      }

      protected void ConfirmValues060( )
      {
         nGXsfl_78_idx = 0;
         sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
         SubsflControlProps_7811( ) ;
         while ( nGXsfl_78_idx < nRC_GXsfl_78 )
         {
            nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
            sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
            SubsflControlProps_7811( ) ;
            ChangePostValue( "Z47idDetalleCompra_"+sGXsfl_78_idx, cgiGet( "ZT_"+"Z47idDetalleCompra_"+sGXsfl_78_idx)) ;
            DeletePostValue( "ZT_"+"Z47idDetalleCompra_"+sGXsfl_78_idx) ;
            ChangePostValue( "Z48cantidadDetalleCompra_"+sGXsfl_78_idx, cgiGet( "ZT_"+"Z48cantidadDetalleCompra_"+sGXsfl_78_idx)) ;
            DeletePostValue( "ZT_"+"Z48cantidadDetalleCompra_"+sGXsfl_78_idx) ;
            ChangePostValue( "Z3idProducto_"+sGXsfl_78_idx, cgiGet( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx)) ;
            DeletePostValue( "ZT_"+"Z3idProducto_"+sGXsfl_78_idx) ;
         }
         ChangePostValue( "O49subtotalDetalleCompra", cgiGet( "T49subtotalDetalleCompra")) ;
         DeletePostValue( "T49subtotalDetalleCompra") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202071613387", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("compra.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z6idCompra", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6idCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z38tipoFacturaCompra", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38tipoFacturaCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z43fechaCompra", context.localUtil.DToC( Z43fechaCompra, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z44porcentajeIVACompra", StringUtil.LTrim( StringUtil.NToC( Z44porcentajeIVACompra, 3, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z2idProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2idProveedor), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "O45totalNetoCompra", StringUtil.LTrim( StringUtil.NToC( O45totalNetoCompra, 10, 2, ".", "")));
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
         return formatLink("compra.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Compra" ;
      }

      public override String GetPgmdesc( )
      {
         return "Compra" ;
      }

      protected void InitializeNonKey066( )
      {
         A46totalAPagarCompra = 0;
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrimStr( A46totalAPagarCompra, 10, 2));
         A38tipoFacturaCompra = 0;
         AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0));
         A43fechaCompra = DateTime.MinValue;
         AssignAttri("", false, "A43fechaCompra", context.localUtil.Format(A43fechaCompra, "99/99/99"));
         A44porcentajeIVACompra = 0;
         AssignAttri("", false, "A44porcentajeIVACompra", StringUtil.LTrimStr( A44porcentajeIVACompra, 3, 2));
         A45totalNetoCompra = 0;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         A2idProveedor = 0;
         AssignAttri("", false, "A2idProveedor", StringUtil.LTrimStr( (decimal)(A2idProveedor), 4, 0));
         A16nombreProveedor = "";
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
         O45totalNetoCompra = A45totalNetoCompra;
         n45totalNetoCompra = false;
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrimStr( A45totalNetoCompra, 10, 2));
         Z38tipoFacturaCompra = 0;
         Z43fechaCompra = DateTime.MinValue;
         Z44porcentajeIVACompra = 0;
         Z2idProveedor = 0;
      }

      protected void InitAll066( )
      {
         A6idCompra = 0;
         AssignAttri("", false, "A6idCompra", StringUtil.LTrimStr( (decimal)(A6idCompra), 4, 0));
         InitializeNonKey066( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0611( )
      {
         A49subtotalDetalleCompra = 0;
         A3idProducto = 0;
         A19descripcionProducto = "";
         A21precioProducto = 0;
         A48cantidadDetalleCompra = 0;
         O49subtotalDetalleCompra = A49subtotalDetalleCompra;
         Z48cantidadDetalleCompra = 0;
         Z3idProducto = 0;
      }

      protected void InitAll0611( )
      {
         A47idDetalleCompra = 0;
         InitializeNonKey0611( ) ;
      }

      protected void StandaloneModalInsert0611( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020716133812", true, true);
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
         context.AddJavascriptSource("compra.js", "?2020716133812", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties11( )
      {
         edtidDetalleCompra_Enabled = defedtidDetalleCompra_Enabled;
         AssignProp("", false, edtidDetalleCompra_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtidDetalleCompra_Enabled), 5, 0), !bGXsfl_78_Refreshing);
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
         edtidCompra_Internalname = "IDCOMPRA";
         cmbtipoFacturaCompra_Internalname = "TIPOFACTURACOMPRA";
         edtfechaCompra_Internalname = "FECHACOMPRA";
         edtporcentajeIVACompra_Internalname = "PORCENTAJEIVACOMPRA";
         edttotalNetoCompra_Internalname = "TOTALNETOCOMPRA";
         edttotalAPagarCompra_Internalname = "TOTALAPAGARCOMPRA";
         edtidProveedor_Internalname = "IDPROVEEDOR";
         edtnombreProveedor_Internalname = "NOMBREPROVEEDOR";
         lblTitleiddetalle_Internalname = "TITLEIDDETALLE";
         edtidDetalleCompra_Internalname = "IDDETALLECOMPRA";
         edtidProducto_Internalname = "IDPRODUCTO";
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO";
         edtprecioProducto_Internalname = "PRECIOPRODUCTO";
         edtcantidadDetalleCompra_Internalname = "CANTIDADDETALLECOMPRA";
         edtsubtotalDetalleCompra_Internalname = "SUBTOTALDETALLECOMPRA";
         divIddetalletable_Internalname = "IDDETALLETABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_3_Internalname = "PROMPT_3";
         subGridcompra_iddetalle_Internalname = "GRIDCOMPRA_IDDETALLE";
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
         Form.Caption = "Compra";
         edtsubtotalDetalleCompra_Jsonclick = "";
         edtcantidadDetalleCompra_Jsonclick = "";
         edtprecioProducto_Jsonclick = "";
         edtdescripcionProducto_Jsonclick = "";
         imgprompt_3_Visible = 1;
         imgprompt_3_Link = "";
         imgprompt_2_Visible = 1;
         edtidProducto_Jsonclick = "";
         edtidDetalleCompra_Jsonclick = "";
         subGridcompra_iddetalle_Class = "Grid";
         subGridcompra_iddetalle_Backcolorstyle = 0;
         subGridcompra_iddetalle_Allowcollapsing = 0;
         subGridcompra_iddetalle_Allowselection = 0;
         edtsubtotalDetalleCompra_Enabled = 0;
         edtcantidadDetalleCompra_Enabled = 1;
         edtprecioProducto_Enabled = 0;
         edtdescripcionProducto_Enabled = 0;
         edtidProducto_Enabled = 1;
         edtidDetalleCompra_Enabled = 1;
         subGridcompra_iddetalle_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtnombreProveedor_Jsonclick = "";
         edtnombreProveedor_Enabled = 0;
         imgprompt_2_Visible = 1;
         imgprompt_2_Link = "";
         edtidProveedor_Jsonclick = "";
         edtidProveedor_Enabled = 1;
         edttotalAPagarCompra_Jsonclick = "";
         edttotalAPagarCompra_Enabled = 0;
         edttotalNetoCompra_Jsonclick = "";
         edttotalNetoCompra_Enabled = 0;
         edtporcentajeIVACompra_Jsonclick = "";
         edtporcentajeIVACompra_Enabled = 1;
         edtfechaCompra_Jsonclick = "";
         edtfechaCompra_Enabled = 1;
         cmbtipoFacturaCompra_Jsonclick = "";
         cmbtipoFacturaCompra.Enabled = 1;
         edtidCompra_Jsonclick = "";
         edtidCompra_Enabled = 1;
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

      protected void gxnrGridcompra_iddetalle_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_7811( ) ;
         while ( nGXsfl_78_idx <= nRC_GXsfl_78 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0611( ) ;
            standaloneModal0611( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0611( ) ;
            nGXsfl_78_idx = (int)(nGXsfl_78_idx+1);
            sGXsfl_78_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_78_idx), 4, 0), 4, "0");
            SubsflControlProps_7811( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridcompra_iddetalleContainer)) ;
         /* End function gxnrGridcompra_iddetalle_newrow */
      }

      protected void init_web_controls( )
      {
         cmbtipoFacturaCompra.Name = "TIPOFACTURACOMPRA";
         cmbtipoFacturaCompra.WebTags = "";
         cmbtipoFacturaCompra.addItem("0", "Factura tipo A", 0);
         cmbtipoFacturaCompra.addItem("1", "Factura tipo B", 0);
         cmbtipoFacturaCompra.addItem("2", "Factura tipo C", 0);
         if ( cmbtipoFacturaCompra.ItemCount > 0 )
         {
            A38tipoFacturaCompra = (short)(NumberUtil.Val( cmbtipoFacturaCompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0))), "."));
            AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0));
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = cmbtipoFacturaCompra_Internalname;
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

      public void Valid_Idcompra( )
      {
         A38tipoFacturaCompra = (short)(NumberUtil.Val( cmbtipoFacturaCompra.CurrentValue, "."));
         cmbtipoFacturaCompra.CurrentValue = StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0);
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T000622 */
         pr_default.execute(16, new Object[] {A6idCompra});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A45totalNetoCompra = T000622_A45totalNetoCompra[0];
            n45totalNetoCompra = T000622_n45totalNetoCompra[0];
         }
         else
         {
            A45totalNetoCompra = 0;
            n45totalNetoCompra = false;
         }
         pr_default.close(16);
         dynload_actions( ) ;
         if ( cmbtipoFacturaCompra.ItemCount > 0 )
         {
            A38tipoFacturaCompra = (short)(NumberUtil.Val( cmbtipoFacturaCompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0))), "."));
            cmbtipoFacturaCompra.CurrentValue = StringUtil.LTrimStr( (decimal)(A38tipoFacturaCompra), 4, 0);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbtipoFacturaCompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0));
         }
         /*  Sending validation outputs */
         AssignAttri("", false, "A38tipoFacturaCompra", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38tipoFacturaCompra), 4, 0, ".", "")));
         cmbtipoFacturaCompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0));
         AssignProp("", false, cmbtipoFacturaCompra_Internalname, "Values", cmbtipoFacturaCompra.ToJavascriptSource(), true);
         AssignAttri("", false, "A43fechaCompra", context.localUtil.Format(A43fechaCompra, "99/99/99"));
         AssignAttri("", false, "A44porcentajeIVACompra", StringUtil.LTrim( StringUtil.NToC( A44porcentajeIVACompra, 3, 2, ".", "")));
         AssignAttri("", false, "A2idProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2idProveedor), 4, 0, ".", "")));
         AssignAttri("", false, "A45totalNetoCompra", StringUtil.LTrim( StringUtil.NToC( A45totalNetoCompra, 10, 2, ".", "")));
         AssignAttri("", false, "A46totalAPagarCompra", StringUtil.LTrim( StringUtil.NToC( A46totalAPagarCompra, 10, 2, ".", "")));
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z6idCompra", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6idCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z38tipoFacturaCompra", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38tipoFacturaCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z43fechaCompra", context.localUtil.Format(Z43fechaCompra, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "Z44porcentajeIVACompra", StringUtil.LTrim( StringUtil.NToC( Z44porcentajeIVACompra, 3, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z2idProveedor", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2idProveedor), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z45totalNetoCompra", StringUtil.LTrim( StringUtil.NToC( Z45totalNetoCompra, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z46totalAPagarCompra", StringUtil.LTrim( StringUtil.NToC( Z46totalAPagarCompra, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z16nombreProveedor", Z16nombreProveedor);
         AssignAttri("", false, "O45totalNetoCompra", StringUtil.LTrim( StringUtil.NToC( O45totalNetoCompra, 10, 2, ".", "")));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Idproveedor( )
      {
         /* Using cursor T000623 */
         pr_default.execute(17, new Object[] {A2idProveedor});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Proveedor'.", "ForeignKeyNotFound", 1, "IDPROVEEDOR");
            AnyError = 1;
            GX_FocusControl = edtidProveedor_Internalname;
         }
         A16nombreProveedor = T000623_A16nombreProveedor[0];
         pr_default.close(17);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A16nombreProveedor", A16nombreProveedor);
      }

      public void Valid_Idproducto( )
      {
         /* Using cursor T000631 */
         pr_default.execute(25, new Object[] {A3idProducto});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No matching 'Producto'.", "ForeignKeyNotFound", 1, "IDPRODUCTO");
            AnyError = 1;
            GX_FocusControl = edtidProducto_Internalname;
         }
         A19descripcionProducto = T000631_A19descripcionProducto[0];
         A21precioProducto = T000631_A21precioProducto[0];
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
         setEventMetadata("VALID_IDCOMPRA","{handler:'Valid_Idcompra',iparms:[{av:'cmbtipoFacturaCompra'},{av:'A38tipoFacturaCompra',fld:'TIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'A6idCompra',fld:'IDCOMPRA',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_IDCOMPRA",",oparms:[{av:'cmbtipoFacturaCompra'},{av:'A38tipoFacturaCompra',fld:'TIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'A43fechaCompra',fld:'FECHACOMPRA',pic:''},{av:'A44porcentajeIVACompra',fld:'PORCENTAJEIVACOMPRA',pic:'9.99'},{av:'A2idProveedor',fld:'IDPROVEEDOR',pic:'ZZZ9'},{av:'A45totalNetoCompra',fld:'TOTALNETOCOMPRA',pic:'ZZZZZZ9.99'},{av:'A46totalAPagarCompra',fld:'TOTALAPAGARCOMPRA',pic:'ZZZZZZ9.99'},{av:'A16nombreProveedor',fld:'NOMBREPROVEEDOR',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z6idCompra'},{av:'Z38tipoFacturaCompra'},{av:'Z43fechaCompra'},{av:'Z44porcentajeIVACompra'},{av:'Z2idProveedor'},{av:'Z45totalNetoCompra'},{av:'Z46totalAPagarCompra'},{av:'Z16nombreProveedor'},{av:'O45totalNetoCompra'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_TIPOFACTURACOMPRA","{handler:'Valid_Tipofacturacompra',iparms:[]");
         setEventMetadata("VALID_TIPOFACTURACOMPRA",",oparms:[]}");
         setEventMetadata("VALID_FECHACOMPRA","{handler:'Valid_Fechacompra',iparms:[]");
         setEventMetadata("VALID_FECHACOMPRA",",oparms:[]}");
         setEventMetadata("VALID_PORCENTAJEIVACOMPRA","{handler:'Valid_Porcentajeivacompra',iparms:[]");
         setEventMetadata("VALID_PORCENTAJEIVACOMPRA",",oparms:[]}");
         setEventMetadata("VALID_TOTALNETOCOMPRA","{handler:'Valid_Totalnetocompra',iparms:[]");
         setEventMetadata("VALID_TOTALNETOCOMPRA",",oparms:[]}");
         setEventMetadata("VALID_IDPROVEEDOR","{handler:'Valid_Idproveedor',iparms:[{av:'A2idProveedor',fld:'IDPROVEEDOR',pic:'ZZZ9'},{av:'A16nombreProveedor',fld:'NOMBREPROVEEDOR',pic:''}]");
         setEventMetadata("VALID_IDPROVEEDOR",",oparms:[{av:'A16nombreProveedor',fld:'NOMBREPROVEEDOR',pic:''}]}");
         setEventMetadata("VALID_IDDETALLECOMPRA","{handler:'Valid_Iddetallecompra',iparms:[]");
         setEventMetadata("VALID_IDDETALLECOMPRA",",oparms:[]}");
         setEventMetadata("VALID_IDPRODUCTO","{handler:'Valid_Idproducto',iparms:[{av:'A3idProducto',fld:'IDPRODUCTO',pic:'ZZZ9'},{av:'A19descripcionProducto',fld:'DESCRIPCIONPRODUCTO',pic:''},{av:'A21precioProducto',fld:'PRECIOPRODUCTO',pic:'ZZZZZZ9.99'}]");
         setEventMetadata("VALID_IDPRODUCTO",",oparms:[{av:'A19descripcionProducto',fld:'DESCRIPCIONPRODUCTO',pic:''},{av:'A21precioProducto',fld:'PRECIOPRODUCTO',pic:'ZZZZZZ9.99'}]}");
         setEventMetadata("VALID_PRECIOPRODUCTO","{handler:'Valid_Precioproducto',iparms:[]");
         setEventMetadata("VALID_PRECIOPRODUCTO",",oparms:[]}");
         setEventMetadata("VALID_CANTIDADDETALLECOMPRA","{handler:'Valid_Cantidaddetallecompra',iparms:[]");
         setEventMetadata("VALID_CANTIDADDETALLECOMPRA",",oparms:[]}");
         setEventMetadata("VALID_SUBTOTALDETALLECOMPRA","{handler:'Valid_Subtotaldetallecompra',iparms:[]");
         setEventMetadata("VALID_SUBTOTALDETALLECOMPRA",",oparms:[]}");
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
         Z43fechaCompra = DateTime.MinValue;
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
         A43fechaCompra = DateTime.MinValue;
         sImgUrl = "";
         A16nombreProveedor = "";
         lblTitleiddetalle_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridcompra_iddetalleContainer = new GXWebGrid( context);
         Gridcompra_iddetalleColumn = new GXWebColumn();
         A19descripcionProducto = "";
         sMode11 = "";
         sStyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         Z16nombreProveedor = "";
         T000611_A6idCompra = new short[1] ;
         T000611_A38tipoFacturaCompra = new short[1] ;
         T000611_A43fechaCompra = new DateTime[] {DateTime.MinValue} ;
         T000611_A44porcentajeIVACompra = new decimal[1] ;
         T000611_A16nombreProveedor = new String[] {""} ;
         T000611_A2idProveedor = new short[1] ;
         T000611_A45totalNetoCompra = new decimal[1] ;
         T000611_n45totalNetoCompra = new bool[] {false} ;
         T00069_A45totalNetoCompra = new decimal[1] ;
         T00069_n45totalNetoCompra = new bool[] {false} ;
         T00067_A16nombreProveedor = new String[] {""} ;
         T000613_A45totalNetoCompra = new decimal[1] ;
         T000613_n45totalNetoCompra = new bool[] {false} ;
         T000614_A16nombreProveedor = new String[] {""} ;
         T000615_A6idCompra = new short[1] ;
         T00066_A6idCompra = new short[1] ;
         T00066_A38tipoFacturaCompra = new short[1] ;
         T00066_A43fechaCompra = new DateTime[] {DateTime.MinValue} ;
         T00066_A44porcentajeIVACompra = new decimal[1] ;
         T00066_A2idProveedor = new short[1] ;
         sMode6 = "";
         T000616_A6idCompra = new short[1] ;
         T000617_A6idCompra = new short[1] ;
         T00065_A6idCompra = new short[1] ;
         T00065_A38tipoFacturaCompra = new short[1] ;
         T00065_A43fechaCompra = new DateTime[] {DateTime.MinValue} ;
         T00065_A44porcentajeIVACompra = new decimal[1] ;
         T00065_A2idProveedor = new short[1] ;
         T000622_A45totalNetoCompra = new decimal[1] ;
         T000622_n45totalNetoCompra = new bool[] {false} ;
         T000623_A16nombreProveedor = new String[] {""} ;
         T000624_A6idCompra = new short[1] ;
         Z19descripcionProducto = "";
         T000625_A6idCompra = new short[1] ;
         T000625_A47idDetalleCompra = new short[1] ;
         T000625_A19descripcionProducto = new String[] {""} ;
         T000625_A21precioProducto = new decimal[1] ;
         T000625_A48cantidadDetalleCompra = new short[1] ;
         T000625_A3idProducto = new short[1] ;
         T00064_A19descripcionProducto = new String[] {""} ;
         T00064_A21precioProducto = new decimal[1] ;
         T000626_A19descripcionProducto = new String[] {""} ;
         T000626_A21precioProducto = new decimal[1] ;
         T000627_A6idCompra = new short[1] ;
         T000627_A47idDetalleCompra = new short[1] ;
         T00063_A6idCompra = new short[1] ;
         T00063_A47idDetalleCompra = new short[1] ;
         T00063_A48cantidadDetalleCompra = new short[1] ;
         T00063_A3idProducto = new short[1] ;
         T00062_A6idCompra = new short[1] ;
         T00062_A47idDetalleCompra = new short[1] ;
         T00062_A48cantidadDetalleCompra = new short[1] ;
         T00062_A3idProducto = new short[1] ;
         T000631_A19descripcionProducto = new String[] {""} ;
         T000631_A21precioProducto = new decimal[1] ;
         T000632_A6idCompra = new short[1] ;
         T000632_A47idDetalleCompra = new short[1] ;
         Gridcompra_iddetalleRow = new GXWebRow();
         subGridcompra_iddetalle_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ43fechaCompra = DateTime.MinValue;
         ZZ16nombreProveedor = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.compra__default(),
            new Object[][] {
                new Object[] {
               T00062_A6idCompra, T00062_A47idDetalleCompra, T00062_A48cantidadDetalleCompra, T00062_A3idProducto
               }
               , new Object[] {
               T00063_A6idCompra, T00063_A47idDetalleCompra, T00063_A48cantidadDetalleCompra, T00063_A3idProducto
               }
               , new Object[] {
               T00064_A19descripcionProducto, T00064_A21precioProducto
               }
               , new Object[] {
               T00065_A6idCompra, T00065_A38tipoFacturaCompra, T00065_A43fechaCompra, T00065_A44porcentajeIVACompra, T00065_A2idProveedor
               }
               , new Object[] {
               T00066_A6idCompra, T00066_A38tipoFacturaCompra, T00066_A43fechaCompra, T00066_A44porcentajeIVACompra, T00066_A2idProveedor
               }
               , new Object[] {
               T00067_A16nombreProveedor
               }
               , new Object[] {
               T00069_A45totalNetoCompra, T00069_n45totalNetoCompra
               }
               , new Object[] {
               T000611_A6idCompra, T000611_A38tipoFacturaCompra, T000611_A43fechaCompra, T000611_A44porcentajeIVACompra, T000611_A16nombreProveedor, T000611_A2idProveedor, T000611_A45totalNetoCompra, T000611_n45totalNetoCompra
               }
               , new Object[] {
               T000613_A45totalNetoCompra, T000613_n45totalNetoCompra
               }
               , new Object[] {
               T000614_A16nombreProveedor
               }
               , new Object[] {
               T000615_A6idCompra
               }
               , new Object[] {
               T000616_A6idCompra
               }
               , new Object[] {
               T000617_A6idCompra
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000622_A45totalNetoCompra, T000622_n45totalNetoCompra
               }
               , new Object[] {
               T000623_A16nombreProveedor
               }
               , new Object[] {
               T000624_A6idCompra
               }
               , new Object[] {
               T000625_A6idCompra, T000625_A47idDetalleCompra, T000625_A19descripcionProducto, T000625_A21precioProducto, T000625_A48cantidadDetalleCompra, T000625_A3idProducto
               }
               , new Object[] {
               T000626_A19descripcionProducto, T000626_A21precioProducto
               }
               , new Object[] {
               T000627_A6idCompra, T000627_A47idDetalleCompra
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000631_A19descripcionProducto, T000631_A21precioProducto
               }
               , new Object[] {
               T000632_A6idCompra, T000632_A47idDetalleCompra
               }
            }
         );
      }

      private short nIsMod_11 ;
      private short Z6idCompra ;
      private short Z38tipoFacturaCompra ;
      private short Z2idProveedor ;
      private short Z47idDetalleCompra ;
      private short Z48cantidadDetalleCompra ;
      private short Z3idProducto ;
      private short nRcdDeleted_11 ;
      private short nRcdExists_11 ;
      private short GxWebError ;
      private short A6idCompra ;
      private short A2idProveedor ;
      private short A3idProducto ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A38tipoFacturaCompra ;
      private short subGridcompra_iddetalle_Backcolorstyle ;
      private short A47idDetalleCompra ;
      private short A48cantidadDetalleCompra ;
      private short subGridcompra_iddetalle_Allowselection ;
      private short subGridcompra_iddetalle_Allowhovering ;
      private short subGridcompra_iddetalle_Allowcollapsing ;
      private short subGridcompra_iddetalle_Collapsed ;
      private short nBlankRcdCount11 ;
      private short RcdFound11 ;
      private short nBlankRcdUsr11 ;
      private short GX_JID ;
      private short RcdFound6 ;
      private short nIsDirty_6 ;
      private short Gx_BScreen ;
      private short nIsDirty_11 ;
      private short subGridcompra_iddetalle_Backstyle ;
      private short gxajaxcallmode ;
      private short ZZ6idCompra ;
      private short ZZ38tipoFacturaCompra ;
      private short ZZ2idProveedor ;
      private int nRC_GXsfl_78 ;
      private int nGXsfl_78_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtidCompra_Enabled ;
      private int edtfechaCompra_Enabled ;
      private int edtporcentajeIVACompra_Enabled ;
      private int edttotalNetoCompra_Enabled ;
      private int edttotalAPagarCompra_Enabled ;
      private int edtidProveedor_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtnombreProveedor_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtidDetalleCompra_Enabled ;
      private int edtidProducto_Enabled ;
      private int edtdescripcionProducto_Enabled ;
      private int edtprecioProducto_Enabled ;
      private int edtcantidadDetalleCompra_Enabled ;
      private int edtsubtotalDetalleCompra_Enabled ;
      private int subGridcompra_iddetalle_Selectedindex ;
      private int subGridcompra_iddetalle_Selectioncolor ;
      private int subGridcompra_iddetalle_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridcompra_iddetalle_Backcolor ;
      private int subGridcompra_iddetalle_Allbackcolor ;
      private int imgprompt_3_Visible ;
      private int defedtidDetalleCompra_Enabled ;
      private int idxLst ;
      private long GRIDCOMPRA_IDDETALLE_nFirstRecordOnPage ;
      private decimal Z44porcentajeIVACompra ;
      private decimal O45totalNetoCompra ;
      private decimal O49subtotalDetalleCompra ;
      private decimal A44porcentajeIVACompra ;
      private decimal A45totalNetoCompra ;
      private decimal A46totalAPagarCompra ;
      private decimal A21precioProducto ;
      private decimal A49subtotalDetalleCompra ;
      private decimal B45totalNetoCompra ;
      private decimal s45totalNetoCompra ;
      private decimal s46totalAPagarCompra ;
      private decimal O46totalAPagarCompra ;
      private decimal T49subtotalDetalleCompra ;
      private decimal Z45totalNetoCompra ;
      private decimal Z21precioProducto ;
      private decimal Z46totalAPagarCompra ;
      private decimal ZZ44porcentajeIVACompra ;
      private decimal ZZ45totalNetoCompra ;
      private decimal ZZ46totalAPagarCompra ;
      private decimal ZO45totalNetoCompra ;
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
      private String edtidCompra_Internalname ;
      private String cmbtipoFacturaCompra_Internalname ;
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
      private String edtidCompra_Jsonclick ;
      private String cmbtipoFacturaCompra_Jsonclick ;
      private String edtfechaCompra_Internalname ;
      private String edtfechaCompra_Jsonclick ;
      private String edtporcentajeIVACompra_Internalname ;
      private String edtporcentajeIVACompra_Jsonclick ;
      private String edttotalNetoCompra_Internalname ;
      private String edttotalNetoCompra_Jsonclick ;
      private String edttotalAPagarCompra_Internalname ;
      private String edttotalAPagarCompra_Jsonclick ;
      private String edtidProveedor_Internalname ;
      private String edtidProveedor_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtnombreProveedor_Internalname ;
      private String edtnombreProveedor_Jsonclick ;
      private String divIddetalletable_Internalname ;
      private String lblTitleiddetalle_Internalname ;
      private String lblTitleiddetalle_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridcompra_iddetalle_Header ;
      private String sMode11 ;
      private String edtidDetalleCompra_Internalname ;
      private String edtidProducto_Internalname ;
      private String edtdescripcionProducto_Internalname ;
      private String edtprecioProducto_Internalname ;
      private String edtcantidadDetalleCompra_Internalname ;
      private String edtsubtotalDetalleCompra_Internalname ;
      private String sStyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sMode6 ;
      private String imgprompt_3_Internalname ;
      private String sGXsfl_78_fel_idx="0001" ;
      private String subGridcompra_iddetalle_Class ;
      private String subGridcompra_iddetalle_Linesclass ;
      private String imgprompt_3_Link ;
      private String ROClassString ;
      private String edtidDetalleCompra_Jsonclick ;
      private String edtidProducto_Jsonclick ;
      private String edtdescripcionProducto_Jsonclick ;
      private String edtprecioProducto_Jsonclick ;
      private String edtcantidadDetalleCompra_Jsonclick ;
      private String edtsubtotalDetalleCompra_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridcompra_iddetalle_Internalname ;
      private DateTime Z43fechaCompra ;
      private DateTime A43fechaCompra ;
      private DateTime ZZ43fechaCompra ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n45totalNetoCompra ;
      private bool bGXsfl_78_Refreshing=false ;
      private String A16nombreProveedor ;
      private String A19descripcionProducto ;
      private String Z16nombreProveedor ;
      private String Z19descripcionProducto ;
      private String ZZ16nombreProveedor ;
      private GXWebGrid Gridcompra_iddetalleContainer ;
      private GXWebRow Gridcompra_iddetalleRow ;
      private GXWebColumn Gridcompra_iddetalleColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbtipoFacturaCompra ;
      private IDataStoreProvider pr_default ;
      private short[] T000611_A6idCompra ;
      private short[] T000611_A38tipoFacturaCompra ;
      private DateTime[] T000611_A43fechaCompra ;
      private decimal[] T000611_A44porcentajeIVACompra ;
      private String[] T000611_A16nombreProveedor ;
      private short[] T000611_A2idProveedor ;
      private decimal[] T000611_A45totalNetoCompra ;
      private bool[] T000611_n45totalNetoCompra ;
      private decimal[] T00069_A45totalNetoCompra ;
      private bool[] T00069_n45totalNetoCompra ;
      private String[] T00067_A16nombreProveedor ;
      private decimal[] T000613_A45totalNetoCompra ;
      private bool[] T000613_n45totalNetoCompra ;
      private String[] T000614_A16nombreProveedor ;
      private short[] T000615_A6idCompra ;
      private short[] T00066_A6idCompra ;
      private short[] T00066_A38tipoFacturaCompra ;
      private DateTime[] T00066_A43fechaCompra ;
      private decimal[] T00066_A44porcentajeIVACompra ;
      private short[] T00066_A2idProveedor ;
      private short[] T000616_A6idCompra ;
      private short[] T000617_A6idCompra ;
      private short[] T00065_A6idCompra ;
      private short[] T00065_A38tipoFacturaCompra ;
      private DateTime[] T00065_A43fechaCompra ;
      private decimal[] T00065_A44porcentajeIVACompra ;
      private short[] T00065_A2idProveedor ;
      private decimal[] T000622_A45totalNetoCompra ;
      private bool[] T000622_n45totalNetoCompra ;
      private String[] T000623_A16nombreProveedor ;
      private short[] T000624_A6idCompra ;
      private short[] T000625_A6idCompra ;
      private short[] T000625_A47idDetalleCompra ;
      private String[] T000625_A19descripcionProducto ;
      private decimal[] T000625_A21precioProducto ;
      private short[] T000625_A48cantidadDetalleCompra ;
      private short[] T000625_A3idProducto ;
      private String[] T00064_A19descripcionProducto ;
      private decimal[] T00064_A21precioProducto ;
      private String[] T000626_A19descripcionProducto ;
      private decimal[] T000626_A21precioProducto ;
      private short[] T000627_A6idCompra ;
      private short[] T000627_A47idDetalleCompra ;
      private short[] T00063_A6idCompra ;
      private short[] T00063_A47idDetalleCompra ;
      private short[] T00063_A48cantidadDetalleCompra ;
      private short[] T00063_A3idProducto ;
      private short[] T00062_A6idCompra ;
      private short[] T00062_A47idDetalleCompra ;
      private short[] T00062_A48cantidadDetalleCompra ;
      private short[] T00062_A3idProducto ;
      private String[] T000631_A19descripcionProducto ;
      private decimal[] T000631_A21precioProducto ;
      private short[] T000632_A6idCompra ;
      private short[] T000632_A47idDetalleCompra ;
      private GXWebForm Form ;
   }

   public class compra__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000617 ;
          prmT000617 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000618 ;
          prmT000618 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoFacturaCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fechaCompra",SqlDbType.DateTime,8,0} ,
          new Object[] {"@porcentajeIVACompra",SqlDbType.Decimal,3,2} ,
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000619 ;
          prmT000619 = new Object[] {
          new Object[] {"@tipoFacturaCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fechaCompra",SqlDbType.DateTime,8,0} ,
          new Object[] {"@porcentajeIVACompra",SqlDbType.Decimal,3,2} ,
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000620 ;
          prmT000620 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000624 ;
          prmT000624 = new Object[] {
          } ;
          Object[] prmT000625 ;
          prmT000625 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000626 ;
          prmT000626 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000627 ;
          prmT000627 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000628 ;
          prmT000628 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@cantidadDetalleCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000629 ;
          prmT000629 = new Object[] {
          new Object[] {"@cantidadDetalleCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000630 ;
          prmT000630 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@idDetalleCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000632 ;
          prmT000632 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000622 ;
          prmT000622 = new Object[] {
          new Object[] {"@idCompra",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000623 ;
          prmT000623 = new Object[] {
          new Object[] {"@idProveedor",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000631 ;
          prmT000631 = new Object[] {
          new Object[] {"@idProducto",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [idCompra], [idDetalleCompra], [cantidadDetalleCompra], [idProducto] FROM [CompraidDetalle] WITH (UPDLOCK) WHERE [idCompra] = @idCompra AND [idDetalleCompra] = @idDetalleCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00063", "SELECT [idCompra], [idDetalleCompra], [cantidadDetalleCompra], [idProducto] FROM [CompraidDetalle] WHERE [idCompra] = @idCompra AND [idDetalleCompra] = @idDetalleCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00064", "SELECT [descripcionProducto], [precioProducto] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00065", "SELECT [idCompra], [tipoFacturaCompra], [fechaCompra], [porcentajeIVACompra], [idProveedor] FROM [Compra] WITH (UPDLOCK) WHERE [idCompra] = @idCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00066", "SELECT [idCompra], [tipoFacturaCompra], [fechaCompra], [porcentajeIVACompra], [idProveedor] FROM [Compra] WHERE [idCompra] = @idCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00067", "SELECT [nombreProveedor] FROM [Proveedor] WHERE [idProveedor] = @idProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00069", "SELECT COALESCE( T1.[totalNetoCompra], 0) AS totalNetoCompra FROM (SELECT SUM(T3.[precioProducto] * CAST(T2.[cantidadDetalleCompra] AS decimal( 20, 10))) AS totalNetoCompra, T2.[idCompra] FROM ([CompraidDetalle] T2 WITH (UPDLOCK) INNER JOIN [Producto] T3 ON T3.[idProducto] = T2.[idProducto]) GROUP BY T2.[idCompra] ) T1 WHERE T1.[idCompra] = @idCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000611", "SELECT TM1.[idCompra], TM1.[tipoFacturaCompra], TM1.[fechaCompra], TM1.[porcentajeIVACompra], T3.[nombreProveedor], TM1.[idProveedor], COALESCE( T2.[totalNetoCompra], 0) AS totalNetoCompra FROM (([Compra] TM1 LEFT JOIN (SELECT SUM(T5.[precioProducto] * CAST(T4.[cantidadDetalleCompra] AS decimal( 20, 10))) AS totalNetoCompra, T4.[idCompra] FROM ([CompraidDetalle] T4 INNER JOIN [Producto] T5 ON T5.[idProducto] = T4.[idProducto]) GROUP BY T4.[idCompra] ) T2 ON T2.[idCompra] = TM1.[idCompra]) INNER JOIN [Proveedor] T3 ON T3.[idProveedor] = TM1.[idProveedor]) WHERE TM1.[idCompra] = @idCompra ORDER BY TM1.[idCompra]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000613", "SELECT COALESCE( T1.[totalNetoCompra], 0) AS totalNetoCompra FROM (SELECT SUM(T3.[precioProducto] * CAST(T2.[cantidadDetalleCompra] AS decimal( 20, 10))) AS totalNetoCompra, T2.[idCompra] FROM ([CompraidDetalle] T2 WITH (UPDLOCK) INNER JOIN [Producto] T3 ON T3.[idProducto] = T2.[idProducto]) GROUP BY T2.[idCompra] ) T1 WHERE T1.[idCompra] = @idCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000614", "SELECT [nombreProveedor] FROM [Proveedor] WHERE [idProveedor] = @idProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000615", "SELECT [idCompra] FROM [Compra] WHERE [idCompra] = @idCompra  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000616", "SELECT TOP 1 [idCompra] FROM [Compra] WHERE ( [idCompra] > @idCompra) ORDER BY [idCompra]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000616,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000617", "SELECT TOP 1 [idCompra] FROM [Compra] WHERE ( [idCompra] < @idCompra) ORDER BY [idCompra] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000617,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000618", "INSERT INTO [Compra]([idCompra], [tipoFacturaCompra], [fechaCompra], [porcentajeIVACompra], [idProveedor]) VALUES(@idCompra, @tipoFacturaCompra, @fechaCompra, @porcentajeIVACompra, @idProveedor)", GxErrorMask.GX_NOMASK,prmT000618)
             ,new CursorDef("T000619", "UPDATE [Compra] SET [tipoFacturaCompra]=@tipoFacturaCompra, [fechaCompra]=@fechaCompra, [porcentajeIVACompra]=@porcentajeIVACompra, [idProveedor]=@idProveedor  WHERE [idCompra] = @idCompra", GxErrorMask.GX_NOMASK,prmT000619)
             ,new CursorDef("T000620", "DELETE FROM [Compra]  WHERE [idCompra] = @idCompra", GxErrorMask.GX_NOMASK,prmT000620)
             ,new CursorDef("T000622", "SELECT COALESCE( T1.[totalNetoCompra], 0) AS totalNetoCompra FROM (SELECT SUM(T3.[precioProducto] * CAST(T2.[cantidadDetalleCompra] AS decimal( 20, 10))) AS totalNetoCompra, T2.[idCompra] FROM ([CompraidDetalle] T2 WITH (UPDLOCK) INNER JOIN [Producto] T3 ON T3.[idProducto] = T2.[idProducto]) GROUP BY T2.[idCompra] ) T1 WHERE T1.[idCompra] = @idCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT000622,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000623", "SELECT [nombreProveedor] FROM [Proveedor] WHERE [idProveedor] = @idProveedor ",true, GxErrorMask.GX_NOMASK, false, this,prmT000623,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000624", "SELECT [idCompra] FROM [Compra] ORDER BY [idCompra]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000624,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000625", "SELECT T1.[idCompra], T1.[idDetalleCompra], T2.[descripcionProducto], T2.[precioProducto], T1.[cantidadDetalleCompra], T1.[idProducto] FROM ([CompraidDetalle] T1 INNER JOIN [Producto] T2 ON T2.[idProducto] = T1.[idProducto]) WHERE T1.[idCompra] = @idCompra and T1.[idDetalleCompra] = @idDetalleCompra ORDER BY T1.[idCompra], T1.[idDetalleCompra] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000625,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000626", "SELECT [descripcionProducto], [precioProducto] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000626,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000627", "SELECT [idCompra], [idDetalleCompra] FROM [CompraidDetalle] WHERE [idCompra] = @idCompra AND [idDetalleCompra] = @idDetalleCompra ",true, GxErrorMask.GX_NOMASK, false, this,prmT000627,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000628", "INSERT INTO [CompraidDetalle]([idCompra], [idDetalleCompra], [cantidadDetalleCompra], [idProducto]) VALUES(@idCompra, @idDetalleCompra, @cantidadDetalleCompra, @idProducto)", GxErrorMask.GX_NOMASK,prmT000628)
             ,new CursorDef("T000629", "UPDATE [CompraidDetalle] SET [cantidadDetalleCompra]=@cantidadDetalleCompra, [idProducto]=@idProducto  WHERE [idCompra] = @idCompra AND [idDetalleCompra] = @idDetalleCompra", GxErrorMask.GX_NOMASK,prmT000629)
             ,new CursorDef("T000630", "DELETE FROM [CompraidDetalle]  WHERE [idCompra] = @idCompra AND [idDetalleCompra] = @idDetalleCompra", GxErrorMask.GX_NOMASK,prmT000630)
             ,new CursorDef("T000631", "SELECT [descripcionProducto], [precioProducto] FROM [Producto] WHERE [idProducto] = @idProducto ",true, GxErrorMask.GX_NOMASK, false, this,prmT000631,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000632", "SELECT [idCompra], [idDetalleCompra] FROM [CompraidDetalle] WHERE [idCompra] = @idCompra ORDER BY [idCompra], [idDetalleCompra] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000632,11, GxCacheFrequency.OFF ,true,false )
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
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
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
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
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
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
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
