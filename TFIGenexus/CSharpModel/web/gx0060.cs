/*
               File: Gx0060
        Description: Selection List Compra
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:3:10.27
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
   public class gx0060 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0060( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0060( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pidCompra )
      {
         this.AV11pidCompra = 0 ;
         executePrivate();
         aP0_pidCompra=this.AV11pidCompra;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCtipofacturacompra = new GXCombobox();
         cmbtipoFacturaCompra = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_64 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_64_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_64_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cidCompra = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7ctipoFacturaCompra = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cfechaCompra = context.localUtil.ParseDateParm( GetNextPar( ));
               AV9cporcentajeIVACompra = NumberUtil.Val( GetNextPar( ), ".");
               AV10cidProveedor = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor) ;
               AddString( context.getJSONResponse( )) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV11pidCompra = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV11pidCompra", StringUtil.LTrimStr( (decimal)(AV11pidCompra), 4, 0));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA0F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0F2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 139369), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 139369), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 139369), false, true);
         context.AddJavascriptSource("gxcfg.js", "?20207161331032", false, true);
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
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0060.aspx") + "?" + UrlEncode("" +AV11pidCompra)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCIDCOMPRA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cidCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOFACTURACOMPRA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ctipoFacturaCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCFECHACOMPRA", context.localUtil.Format(AV8cfechaCompra, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCPORCENTAJEIVACOMPRA", StringUtil.LTrim( StringUtil.NToC( AV9cporcentajeIVACompra, 3, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCIDPROVEEDOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cidProveedor), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_64", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_64), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPIDCOMPRA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pidCompra), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "IDCOMPRAFILTERCONTAINER_Class", StringUtil.RTrim( divIdcomprafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOFACTURACOMPRAFILTERCONTAINER_Class", StringUtil.RTrim( divTipofacturacomprafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "FECHACOMPRAFILTERCONTAINER_Class", StringUtil.RTrim( divFechacomprafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PORCENTAJEIVACOMPRAFILTERCONTAINER_Class", StringUtil.RTrim( divPorcentajeivacomprafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "IDPROVEEDORFILTERCONTAINER_Class", StringUtil.RTrim( divIdproveedorfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0F2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0F2( ) ;
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
         return formatLink("gx0060.aspx") + "?" + UrlEncode("" +AV11pidCompra) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0060" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Compra" ;
      }

      protected void WB0F0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divIdcomprafiltercontainer_Internalname, 1, 0, "px", 0, "px", divIdcomprafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblidcomprafilter_Internalname, "id Compra", "", "", lblLblidcomprafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCidcompra_Internalname, "id Compra", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCidcompra_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cidCompra), 4, 0, ".", "")), ((edtavCidcompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cidCompra), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cidCompra), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCidcompra_Jsonclick, 0, "Attribute", "", "", "", "", edtavCidcompra_Visible, edtavCidcompra_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTipofacturacomprafiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipofacturacomprafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipofacturacomprafilter_Internalname, "tipo Factura Compra", "", "", lblLbltipofacturacomprafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCtipofacturacompra_Internalname, "tipo Factura Compra", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_64_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipofacturacompra, cmbavCtipofacturacompra_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV7ctipoFacturaCompra), 4, 0)), 1, cmbavCtipofacturacompra_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCtipofacturacompra.Visible, cmbavCtipofacturacompra.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "", true, "HLP_Gx0060.htm");
            cmbavCtipofacturacompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7ctipoFacturaCompra), 4, 0));
            AssignProp("", false, cmbavCtipofacturacompra_Internalname, "Values", (String)(cmbavCtipofacturacompra.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFechacomprafiltercontainer_Internalname, 1, 0, "px", 0, "px", divFechacomprafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblfechacomprafilter_Internalname, "fecha Compra", "", "", lblLblfechacomprafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130f1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCfechacompra_Internalname, "fecha Compra", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_64_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCfechacompra_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCfechacompra_Internalname, context.localUtil.Format(AV8cfechaCompra, "99/99/99"), context.localUtil.Format( AV8cfechaCompra, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCfechacompra_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCfechacompra_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0060.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPorcentajeivacomprafiltercontainer_Internalname, 1, 0, "px", 0, "px", divPorcentajeivacomprafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblporcentajeivacomprafilter_Internalname, "porcentaje IVACompra", "", "", lblLblporcentajeivacomprafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCporcentajeivacompra_Internalname, "porcentaje IVACompra", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCporcentajeivacompra_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cporcentajeIVACompra, 4, 2, ".", "")), ((edtavCporcentajeivacompra_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cporcentajeIVACompra, "9.99")) : context.localUtil.Format( AV9cporcentajeIVACompra, "9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCporcentajeivacompra_Jsonclick, 0, "Attribute", "", "", "", "", edtavCporcentajeivacompra_Visible, edtavCporcentajeivacompra_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divIdproveedorfiltercontainer_Internalname, 1, 0, "px", 0, "px", divIdproveedorfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblidproveedorfilter_Internalname, "id Proveedor", "", "", lblLblidproveedorfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150f1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCidproveedor_Internalname, "id Proveedor", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCidproveedor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cidProveedor), 4, 0, ".", "")), ((edtavCidproveedor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cidProveedor), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10cidProveedor), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCidproveedor_Jsonclick, 0, "Attribute", "", "", "", "", edtavCidproveedor_Visible, edtavCidproveedor_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e160f1_client"+"'", TempTags, "", 2, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"64\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Compra") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Factura Compra") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Compra") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "IVACompra") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "id Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6idCompra), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38tipoFacturaCompra), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( cmbtipoFacturaCompra.Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A43fechaCompra, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A44porcentajeIVACompra, 4, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2idProveedor), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 64 )
         {
            wbEnd = 0;
            nRC_GXsfl_64 = (int)(nGXsfl_64_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 64 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START0F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_8-139369", 0) ;
            Form.Meta.addItem("description", "Selection List Compra", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0F0( ) ;
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_64_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
                              SubsflControlProps_642( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_64_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A6idCompra = (short)(context.localUtil.CToN( cgiGet( edtidCompra_Internalname), ".", ","));
                              cmbtipoFacturaCompra.Name = cmbtipoFacturaCompra_Internalname;
                              cmbtipoFacturaCompra.CurrentValue = cgiGet( cmbtipoFacturaCompra_Internalname);
                              A38tipoFacturaCompra = (short)(NumberUtil.Val( cgiGet( cmbtipoFacturaCompra_Internalname), "."));
                              A43fechaCompra = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtfechaCompra_Internalname), 0));
                              A44porcentajeIVACompra = context.localUtil.CToN( cgiGet( edtporcentajeIVACompra_Internalname), ".", ",");
                              A2idProveedor = (short)(context.localUtil.CToN( cgiGet( edtidProveedor_Internalname), ".", ","));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E170F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E180F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cidcompra Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCIDCOMPRA"), ".", ",") != Convert.ToDecimal( AV6cidCompra )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipofacturacompra Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOFACTURACOMPRA"), ".", ",") != Convert.ToDecimal( AV7ctipoFacturaCompra )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cfechacompra Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCFECHACOMPRA"), 0) != AV8cfechaCompra )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cporcentajeivacompra Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPORCENTAJEIVACOMPRA"), ".", ",") != AV9cporcentajeIVACompra )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cidproveedor Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCIDPROVEEDOR"), ".", ",") != Convert.ToDecimal( AV10cidProveedor )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E190F2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0F2( )
      {
         if ( nDonePA == 0 )
         {
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_642( ) ;
         while ( nGXsfl_64_idx <= nRC_GXsfl_64 )
         {
            sendrow_642( ) ;
            nGXsfl_64_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1);
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
            SubsflControlProps_642( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cidCompra ,
                                        short AV7ctipoFacturaCompra ,
                                        DateTime AV8cfechaCompra ,
                                        decimal AV9cporcentajeIVACompra ,
                                        short AV10cidProveedor )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF0F2( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         send_integrity_footer_hashes( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_IDCOMPRA", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A6idCompra), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "IDCOMPRA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6idCompra), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
            before_start_formulas( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbavCtipofacturacompra.ItemCount > 0 )
         {
            AV7ctipoFacturaCompra = (short)(NumberUtil.Val( cmbavCtipofacturacompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7ctipoFacturaCompra), 4, 0))), "."));
            AssignAttri("", false, "AV7ctipoFacturaCompra", StringUtil.LTrimStr( (decimal)(AV7ctipoFacturaCompra), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCtipofacturacompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV7ctipoFacturaCompra), 4, 0));
            AssignProp("", false, cmbavCtipofacturacompra_Internalname, "Values", cmbavCtipofacturacompra.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 64;
         nGXsfl_64_idx = 1;
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
         SubsflControlProps_642( ) ;
         bGXsfl_64_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_642( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7ctipoFacturaCompra ,
                                                 AV8cfechaCompra ,
                                                 AV9cporcentajeIVACompra ,
                                                 AV10cidProveedor ,
                                                 A38tipoFacturaCompra ,
                                                 A43fechaCompra ,
                                                 A44porcentajeIVACompra ,
                                                 A2idProveedor ,
                                                 AV6cidCompra } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H000F2 */
            pr_default.execute(0, new Object[] {AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_64_idx = 1;
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
            SubsflControlProps_642( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A2idProveedor = H000F2_A2idProveedor[0];
               A44porcentajeIVACompra = H000F2_A44porcentajeIVACompra[0];
               A43fechaCompra = H000F2_A43fechaCompra[0];
               A38tipoFacturaCompra = H000F2_A38tipoFacturaCompra[0];
               A6idCompra = H000F2_A6idCompra[0];
               /* Execute user event: Load */
               E180F2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 64;
            WB0F0( ) ;
         }
         bGXsfl_64_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0F2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_IDCOMPRA"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, context.localUtil.Format( (decimal)(A6idCompra), "ZZZ9"), context));
      }

      protected int subGrid1_fnc_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_fnc_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7ctipoFacturaCompra ,
                                              AV8cfechaCompra ,
                                              AV9cporcentajeIVACompra ,
                                              AV10cidProveedor ,
                                              A38tipoFacturaCompra ,
                                              A43fechaCompra ,
                                              A44porcentajeIVACompra ,
                                              A2idProveedor ,
                                              AV6cidCompra } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H000F3 */
         pr_default.execute(1, new Object[] {AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor});
         GRID1_nRecordCount = H000F3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_fnc_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_fnc_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_fnc_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_fnc_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidCompra, AV7ctipoFacturaCompra, AV8cfechaCompra, AV9cporcentajeIVACompra, AV10cidProveedor) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E170F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_64 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_64"), ".", ","));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCidcompra_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCidcompra_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCIDCOMPRA");
               GX_FocusControl = edtavCidcompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cidCompra = 0;
               AssignAttri("", false, "AV6cidCompra", StringUtil.LTrimStr( (decimal)(AV6cidCompra), 4, 0));
            }
            else
            {
               AV6cidCompra = (short)(context.localUtil.CToN( cgiGet( edtavCidcompra_Internalname), ".", ","));
               AssignAttri("", false, "AV6cidCompra", StringUtil.LTrimStr( (decimal)(AV6cidCompra), 4, 0));
            }
            cmbavCtipofacturacompra.Name = cmbavCtipofacturacompra_Internalname;
            cmbavCtipofacturacompra.CurrentValue = cgiGet( cmbavCtipofacturacompra_Internalname);
            AV7ctipoFacturaCompra = (short)(NumberUtil.Val( cgiGet( cmbavCtipofacturacompra_Internalname), "."));
            AssignAttri("", false, "AV7ctipoFacturaCompra", StringUtil.LTrimStr( (decimal)(AV7ctipoFacturaCompra), 4, 0));
            if ( context.localUtil.VCDate( cgiGet( edtavCfechacompra_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"fecha Compra"}), 1, "vCFECHACOMPRA");
               GX_FocusControl = edtavCfechacompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cfechaCompra = DateTime.MinValue;
               AssignAttri("", false, "AV8cfechaCompra", context.localUtil.Format(AV8cfechaCompra, "99/99/99"));
            }
            else
            {
               AV8cfechaCompra = context.localUtil.CToD( cgiGet( edtavCfechacompra_Internalname), 1);
               AssignAttri("", false, "AV8cfechaCompra", context.localUtil.Format(AV8cfechaCompra, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCporcentajeivacompra_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCporcentajeivacompra_Internalname), ".", ",") > 0.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORCENTAJEIVACOMPRA");
               GX_FocusControl = edtavCporcentajeivacompra_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cporcentajeIVACompra = 0;
               AssignAttri("", false, "AV9cporcentajeIVACompra", StringUtil.LTrimStr( AV9cporcentajeIVACompra, 3, 2));
            }
            else
            {
               AV9cporcentajeIVACompra = context.localUtil.CToN( cgiGet( edtavCporcentajeivacompra_Internalname), ".", ",");
               AssignAttri("", false, "AV9cporcentajeIVACompra", StringUtil.LTrimStr( AV9cporcentajeIVACompra, 3, 2));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCidproveedor_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCidproveedor_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCIDPROVEEDOR");
               GX_FocusControl = edtavCidproveedor_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cidProveedor = 0;
               AssignAttri("", false, "AV10cidProveedor", StringUtil.LTrimStr( (decimal)(AV10cidProveedor), 4, 0));
            }
            else
            {
               AV10cidProveedor = (short)(context.localUtil.CToN( cgiGet( edtavCidproveedor_Internalname), ".", ","));
               AssignAttri("", false, "AV10cidProveedor", StringUtil.LTrimStr( (decimal)(AV10cidProveedor), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCIDCOMPRA"), ".", ",") != Convert.ToDecimal( AV6cidCompra )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOFACTURACOMPRA"), ".", ",") != Convert.ToDecimal( AV7ctipoFacturaCompra )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vCFECHACOMPRA"), 1) != AV8cfechaCompra )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCPORCENTAJEIVACOMPRA"), ".", ",") != AV9cporcentajeIVACompra )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCIDPROVEEDOR"), ".", ",") != Convert.ToDecimal( AV10cidProveedor )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E170F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E170F2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Compra", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV12ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E180F2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV15Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_642( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_64_Refreshing )
         {
            context.DoAjaxLoad(64, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E190F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E190F2( )
      {
         /* Enter Routine */
         AV11pidCompra = A6idCompra;
         AssignAttri("", false, "AV11pidCompra", StringUtil.LTrimStr( (decimal)(AV11pidCompra), 4, 0));
         context.setWebReturnParms(new Object[] {(short)AV11pidCompra});
         context.setWebReturnParmsMetadata(new Object[] {"AV11pidCompra"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pidCompra = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV11pidCompra", StringUtil.LTrimStr( (decimal)(AV11pidCompra), 4, 0));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20207161331071", true, true);
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
         context.AddJavascriptSource("gx0060.js", "?20207161331071", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtidCompra_Internalname = "IDCOMPRA_"+sGXsfl_64_idx;
         cmbtipoFacturaCompra_Internalname = "TIPOFACTURACOMPRA_"+sGXsfl_64_idx;
         edtfechaCompra_Internalname = "FECHACOMPRA_"+sGXsfl_64_idx;
         edtporcentajeIVACompra_Internalname = "PORCENTAJEIVACOMPRA_"+sGXsfl_64_idx;
         edtidProveedor_Internalname = "IDPROVEEDOR_"+sGXsfl_64_idx;
      }

      protected void SubsflControlProps_fel_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_fel_idx;
         edtidCompra_Internalname = "IDCOMPRA_"+sGXsfl_64_fel_idx;
         cmbtipoFacturaCompra_Internalname = "TIPOFACTURACOMPRA_"+sGXsfl_64_fel_idx;
         edtfechaCompra_Internalname = "FECHACOMPRA_"+sGXsfl_64_fel_idx;
         edtporcentajeIVACompra_Internalname = "PORCENTAJEIVACOMPRA_"+sGXsfl_64_fel_idx;
         edtidProveedor_Internalname = "IDPROVEEDOR_"+sGXsfl_64_fel_idx;
      }

      protected void sendrow_642( )
      {
         SubsflControlProps_642( ) ;
         WB0F0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_64_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_64_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_64_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A6idCompra), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_64_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV15Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidCompra_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A6idCompra), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A6idCompra), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidCompra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbtipoFacturaCompra.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOFACTURACOMPRA_" + sGXsfl_64_idx;
               cmbtipoFacturaCompra.Name = GXCCtl;
               cmbtipoFacturaCompra.WebTags = "";
               cmbtipoFacturaCompra.addItem("0", "Factura tipo A", 0);
               cmbtipoFacturaCompra.addItem("1", "Factura tipo B", 0);
               cmbtipoFacturaCompra.addItem("2", "Factura tipo C", 0);
               if ( cmbtipoFacturaCompra.ItemCount > 0 )
               {
                  A38tipoFacturaCompra = (short)(NumberUtil.Val( cmbtipoFacturaCompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0))), "."));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbtipoFacturaCompra,(String)cmbtipoFacturaCompra_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0)),(short)1,(String)cmbtipoFacturaCompra_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"DescriptionAttribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbtipoFacturaCompra.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0));
            AssignProp("", false, cmbtipoFacturaCompra_Internalname, "Values", (String)(cmbtipoFacturaCompra.ToJavascriptSource()), !bGXsfl_64_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfechaCompra_Internalname,context.localUtil.Format(A43fechaCompra, "99/99/99"),context.localUtil.Format( A43fechaCompra, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfechaCompra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtporcentajeIVACompra_Internalname,StringUtil.LTrim( StringUtil.NToC( A44porcentajeIVACompra, 4, 2, ".", "")),context.localUtil.Format( A44porcentajeIVACompra, "9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtporcentajeIVACompra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2idProveedor), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A2idProveedor), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidProveedor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            send_integrity_lvl_hashes0F2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_64_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1);
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
            SubsflControlProps_642( ) ;
         }
         /* End function sendrow_642 */
      }

      protected void init_web_controls( )
      {
         cmbavCtipofacturacompra.Name = "vCTIPOFACTURACOMPRA";
         cmbavCtipofacturacompra.WebTags = "";
         cmbavCtipofacturacompra.addItem("0", "Factura tipo A", 0);
         cmbavCtipofacturacompra.addItem("1", "Factura tipo B", 0);
         cmbavCtipofacturacompra.addItem("2", "Factura tipo C", 0);
         if ( cmbavCtipofacturacompra.ItemCount > 0 )
         {
            AV7ctipoFacturaCompra = (short)(NumberUtil.Val( cmbavCtipofacturacompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV7ctipoFacturaCompra), 4, 0))), "."));
            AssignAttri("", false, "AV7ctipoFacturaCompra", StringUtil.LTrimStr( (decimal)(AV7ctipoFacturaCompra), 4, 0));
         }
         GXCCtl = "TIPOFACTURACOMPRA_" + sGXsfl_64_idx;
         cmbtipoFacturaCompra.Name = GXCCtl;
         cmbtipoFacturaCompra.WebTags = "";
         cmbtipoFacturaCompra.addItem("0", "Factura tipo A", 0);
         cmbtipoFacturaCompra.addItem("1", "Factura tipo B", 0);
         cmbtipoFacturaCompra.addItem("2", "Factura tipo C", 0);
         if ( cmbtipoFacturaCompra.ItemCount > 0 )
         {
            A38tipoFacturaCompra = (short)(NumberUtil.Val( cmbtipoFacturaCompra.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A38tipoFacturaCompra), 4, 0))), "."));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblidcomprafilter_Internalname = "LBLIDCOMPRAFILTER";
         edtavCidcompra_Internalname = "vCIDCOMPRA";
         divIdcomprafiltercontainer_Internalname = "IDCOMPRAFILTERCONTAINER";
         lblLbltipofacturacomprafilter_Internalname = "LBLTIPOFACTURACOMPRAFILTER";
         cmbavCtipofacturacompra_Internalname = "vCTIPOFACTURACOMPRA";
         divTipofacturacomprafiltercontainer_Internalname = "TIPOFACTURACOMPRAFILTERCONTAINER";
         lblLblfechacomprafilter_Internalname = "LBLFECHACOMPRAFILTER";
         edtavCfechacompra_Internalname = "vCFECHACOMPRA";
         divFechacomprafiltercontainer_Internalname = "FECHACOMPRAFILTERCONTAINER";
         lblLblporcentajeivacomprafilter_Internalname = "LBLPORCENTAJEIVACOMPRAFILTER";
         edtavCporcentajeivacompra_Internalname = "vCPORCENTAJEIVACOMPRA";
         divPorcentajeivacomprafiltercontainer_Internalname = "PORCENTAJEIVACOMPRAFILTERCONTAINER";
         lblLblidproveedorfilter_Internalname = "LBLIDPROVEEDORFILTER";
         edtavCidproveedor_Internalname = "vCIDPROVEEDOR";
         divIdproveedorfiltercontainer_Internalname = "IDPROVEEDORFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtidCompra_Internalname = "IDCOMPRA";
         cmbtipoFacturaCompra_Internalname = "TIPOFACTURACOMPRA";
         edtfechaCompra_Internalname = "FECHACOMPRA";
         edtporcentajeIVACompra_Internalname = "PORCENTAJEIVACOMPRA";
         edtidProveedor_Internalname = "IDPROVEEDOR";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtidProveedor_Jsonclick = "";
         edtporcentajeIVACompra_Jsonclick = "";
         edtfechaCompra_Jsonclick = "";
         cmbtipoFacturaCompra_Jsonclick = "";
         edtidCompra_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         cmbtipoFacturaCompra.Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCidproveedor_Jsonclick = "";
         edtavCidproveedor_Enabled = 1;
         edtavCidproveedor_Visible = 1;
         edtavCporcentajeivacompra_Jsonclick = "";
         edtavCporcentajeivacompra_Enabled = 1;
         edtavCporcentajeivacompra_Visible = 1;
         edtavCfechacompra_Jsonclick = "";
         edtavCfechacompra_Enabled = 1;
         cmbavCtipofacturacompra_Jsonclick = "";
         cmbavCtipofacturacompra.Enabled = 1;
         cmbavCtipofacturacompra.Visible = 1;
         edtavCidcompra_Jsonclick = "";
         edtavCidcompra_Enabled = 1;
         edtavCidcompra_Visible = 1;
         divIdproveedorfiltercontainer_Class = "AdvancedContainerItem";
         divPorcentajeivacomprafiltercontainer_Class = "AdvancedContainerItem";
         divFechacomprafiltercontainer_Class = "AdvancedContainerItem";
         divTipofacturacomprafiltercontainer_Class = "AdvancedContainerItem";
         divIdcomprafiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Compra";
         subGrid1_Rows = 10;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidCompra',fld:'vCIDCOMPRA',pic:'ZZZ9'},{av:'cmbavCtipofacturacompra'},{av:'AV7ctipoFacturaCompra',fld:'vCTIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'AV8cfechaCompra',fld:'vCFECHACOMPRA',pic:''},{av:'AV9cporcentajeIVACompra',fld:'vCPORCENTAJEIVACOMPRA',pic:'9.99'},{av:'AV10cidProveedor',fld:'vCIDPROVEEDOR',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E160F1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLIDCOMPRAFILTER.CLICK","{handler:'E110F1',iparms:[{av:'divIdcomprafiltercontainer_Class',ctrl:'IDCOMPRAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLIDCOMPRAFILTER.CLICK",",oparms:[{av:'divIdcomprafiltercontainer_Class',ctrl:'IDCOMPRAFILTERCONTAINER',prop:'Class'},{av:'edtavCidcompra_Visible',ctrl:'vCIDCOMPRA',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOFACTURACOMPRAFILTER.CLICK","{handler:'E120F1',iparms:[{av:'divTipofacturacomprafiltercontainer_Class',ctrl:'TIPOFACTURACOMPRAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOFACTURACOMPRAFILTER.CLICK",",oparms:[{av:'divTipofacturacomprafiltercontainer_Class',ctrl:'TIPOFACTURACOMPRAFILTERCONTAINER',prop:'Class'},{av:'cmbavCtipofacturacompra'}]}");
         setEventMetadata("LBLFECHACOMPRAFILTER.CLICK","{handler:'E130F1',iparms:[{av:'divFechacomprafiltercontainer_Class',ctrl:'FECHACOMPRAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLFECHACOMPRAFILTER.CLICK",",oparms:[{av:'divFechacomprafiltercontainer_Class',ctrl:'FECHACOMPRAFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLPORCENTAJEIVACOMPRAFILTER.CLICK","{handler:'E140F1',iparms:[{av:'divPorcentajeivacomprafiltercontainer_Class',ctrl:'PORCENTAJEIVACOMPRAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLPORCENTAJEIVACOMPRAFILTER.CLICK",",oparms:[{av:'divPorcentajeivacomprafiltercontainer_Class',ctrl:'PORCENTAJEIVACOMPRAFILTERCONTAINER',prop:'Class'},{av:'edtavCporcentajeivacompra_Visible',ctrl:'vCPORCENTAJEIVACOMPRA',prop:'Visible'}]}");
         setEventMetadata("LBLIDPROVEEDORFILTER.CLICK","{handler:'E150F1',iparms:[{av:'divIdproveedorfiltercontainer_Class',ctrl:'IDPROVEEDORFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLIDPROVEEDORFILTER.CLICK",",oparms:[{av:'divIdproveedorfiltercontainer_Class',ctrl:'IDPROVEEDORFILTERCONTAINER',prop:'Class'},{av:'edtavCidproveedor_Visible',ctrl:'vCIDPROVEEDOR',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E190F2',iparms:[{av:'A6idCompra',fld:'IDCOMPRA',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV11pidCompra',fld:'vPIDCOMPRA',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidCompra',fld:'vCIDCOMPRA',pic:'ZZZ9'},{av:'cmbavCtipofacturacompra'},{av:'AV7ctipoFacturaCompra',fld:'vCTIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'AV8cfechaCompra',fld:'vCFECHACOMPRA',pic:''},{av:'AV9cporcentajeIVACompra',fld:'vCPORCENTAJEIVACOMPRA',pic:'9.99'},{av:'AV10cidProveedor',fld:'vCIDPROVEEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidCompra',fld:'vCIDCOMPRA',pic:'ZZZ9'},{av:'cmbavCtipofacturacompra'},{av:'AV7ctipoFacturaCompra',fld:'vCTIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'AV8cfechaCompra',fld:'vCFECHACOMPRA',pic:''},{av:'AV9cporcentajeIVACompra',fld:'vCPORCENTAJEIVACOMPRA',pic:'9.99'},{av:'AV10cidProveedor',fld:'vCIDPROVEEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidCompra',fld:'vCIDCOMPRA',pic:'ZZZ9'},{av:'cmbavCtipofacturacompra'},{av:'AV7ctipoFacturaCompra',fld:'vCTIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'AV8cfechaCompra',fld:'vCFECHACOMPRA',pic:''},{av:'AV9cporcentajeIVACompra',fld:'vCPORCENTAJEIVACOMPRA',pic:'9.99'},{av:'AV10cidProveedor',fld:'vCIDPROVEEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidCompra',fld:'vCIDCOMPRA',pic:'ZZZ9'},{av:'cmbavCtipofacturacompra'},{av:'AV7ctipoFacturaCompra',fld:'vCTIPOFACTURACOMPRA',pic:'ZZZ9'},{av:'AV8cfechaCompra',fld:'vCFECHACOMPRA',pic:''},{av:'AV9cporcentajeIVACompra',fld:'vCPORCENTAJEIVACOMPRA',pic:'9.99'},{av:'AV10cidProveedor',fld:'vCIDPROVEEDOR',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("VALIDV_CTIPOFACTURACOMPRA","{handler:'Validv_Ctipofacturacompra',iparms:[]");
         setEventMetadata("VALIDV_CTIPOFACTURACOMPRA",",oparms:[]}");
         setEventMetadata("VALIDV_CFECHACOMPRA","{handler:'Validv_Cfechacompra',iparms:[]");
         setEventMetadata("VALIDV_CFECHACOMPRA",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Idproveedor',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV8cfechaCompra = DateTime.MinValue;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblidcomprafilter_Jsonclick = "";
         TempTags = "";
         lblLbltipofacturacomprafilter_Jsonclick = "";
         lblLblfechacomprafilter_Jsonclick = "";
         lblLblporcentajeivacomprafilter_Jsonclick = "";
         lblLblidproveedorfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A43fechaCompra = DateTime.MinValue;
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Linkselection_GXI = "";
         scmdbuf = "";
         H000F2_A2idProveedor = new short[1] ;
         H000F2_A44porcentajeIVACompra = new decimal[1] ;
         H000F2_A43fechaCompra = new DateTime[] {DateTime.MinValue} ;
         H000F2_A38tipoFacturaCompra = new short[1] ;
         H000F2_A6idCompra = new short[1] ;
         H000F3_AGRID1_nRecordCount = new long[1] ;
         AV12ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0060__default(),
            new Object[][] {
                new Object[] {
               H000F2_A2idProveedor, H000F2_A44porcentajeIVACompra, H000F2_A43fechaCompra, H000F2_A38tipoFacturaCompra, H000F2_A6idCompra
               }
               , new Object[] {
               H000F3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GRID1_nEOF ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV6cidCompra ;
      private short AV7ctipoFacturaCompra ;
      private short AV10cidProveedor ;
      private short AV11pidCompra ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A6idCompra ;
      private short A38tipoFacturaCompra ;
      private short A2idProveedor ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_64 ;
      private int nGXsfl_64_idx=1 ;
      private int subGrid1_Rows ;
      private int edtavCidcompra_Enabled ;
      private int edtavCidcompra_Visible ;
      private int edtavCfechacompra_Enabled ;
      private int edtavCporcentajeivacompra_Enabled ;
      private int edtavCporcentajeivacompra_Visible ;
      private int edtavCidproveedor_Enabled ;
      private int edtavCidproveedor_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV9cporcentajeIVACompra ;
      private decimal A44porcentajeIVACompra ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divIdcomprafiltercontainer_Class ;
      private String divTipofacturacomprafiltercontainer_Class ;
      private String divFechacomprafiltercontainer_Class ;
      private String divPorcentajeivacomprafiltercontainer_Class ;
      private String divIdproveedorfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_64_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divIdcomprafiltercontainer_Internalname ;
      private String lblLblidcomprafilter_Internalname ;
      private String lblLblidcomprafilter_Jsonclick ;
      private String edtavCidcompra_Internalname ;
      private String TempTags ;
      private String edtavCidcompra_Jsonclick ;
      private String divTipofacturacomprafiltercontainer_Internalname ;
      private String lblLbltipofacturacomprafilter_Internalname ;
      private String lblLbltipofacturacomprafilter_Jsonclick ;
      private String cmbavCtipofacturacompra_Internalname ;
      private String cmbavCtipofacturacompra_Jsonclick ;
      private String divFechacomprafiltercontainer_Internalname ;
      private String lblLblfechacomprafilter_Internalname ;
      private String lblLblfechacomprafilter_Jsonclick ;
      private String edtavCfechacompra_Internalname ;
      private String edtavCfechacompra_Jsonclick ;
      private String divPorcentajeivacomprafiltercontainer_Internalname ;
      private String lblLblporcentajeivacomprafilter_Internalname ;
      private String lblLblporcentajeivacomprafilter_Jsonclick ;
      private String edtavCporcentajeivacompra_Internalname ;
      private String edtavCporcentajeivacompra_Jsonclick ;
      private String divIdproveedorfiltercontainer_Internalname ;
      private String lblLblidproveedorfilter_Internalname ;
      private String lblLblidproveedorfilter_Jsonclick ;
      private String edtavCidproveedor_Internalname ;
      private String edtavCidproveedor_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtidCompra_Internalname ;
      private String cmbtipoFacturaCompra_Internalname ;
      private String edtfechaCompra_Internalname ;
      private String edtporcentajeIVACompra_Internalname ;
      private String edtidProveedor_Internalname ;
      private String scmdbuf ;
      private String AV12ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_64_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtidCompra_Jsonclick ;
      private String GXCCtl ;
      private String cmbtipoFacturaCompra_Jsonclick ;
      private String edtfechaCompra_Jsonclick ;
      private String edtporcentajeIVACompra_Jsonclick ;
      private String edtidProveedor_Jsonclick ;
      private DateTime AV8cfechaCompra ;
      private DateTime A43fechaCompra ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_64_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV15Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCtipofacturacompra ;
      private GXCombobox cmbtipoFacturaCompra ;
      private IDataStoreProvider pr_default ;
      private short[] H000F2_A2idProveedor ;
      private decimal[] H000F2_A44porcentajeIVACompra ;
      private DateTime[] H000F2_A43fechaCompra ;
      private short[] H000F2_A38tipoFacturaCompra ;
      private short[] H000F2_A6idCompra ;
      private long[] H000F3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pidCompra ;
      private GXWebForm Form ;
   }

   public class gx0060__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000F2( IGxContext context ,
                                             short AV7ctipoFacturaCompra ,
                                             DateTime AV8cfechaCompra ,
                                             decimal AV9cporcentajeIVACompra ,
                                             short AV10cidProveedor ,
                                             short A38tipoFacturaCompra ,
                                             DateTime A43fechaCompra ,
                                             decimal A44porcentajeIVACompra ,
                                             short A2idProveedor ,
                                             short AV6cidCompra )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [8] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [idProveedor], [porcentajeIVACompra], [fechaCompra], [tipoFacturaCompra], [idCompra]";
         sFromString = " FROM [Compra]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([idCompra] >= @AV6cidCompra)";
         if ( ! (0==AV7ctipoFacturaCompra) )
         {
            sWhereString = sWhereString + " and ([tipoFacturaCompra] >= @AV7ctipoFacturaCompra)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV8cfechaCompra) )
         {
            sWhereString = sWhereString + " and ([fechaCompra] >= @AV8cfechaCompra)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cporcentajeIVACompra) )
         {
            sWhereString = sWhereString + " and ([porcentajeIVACompra] >= @AV9cporcentajeIVACompra)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cidProveedor) )
         {
            sWhereString = sWhereString + " and ([idProveedor] >= @AV10cidProveedor)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [idCompra]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000F3( IGxContext context ,
                                             short AV7ctipoFacturaCompra ,
                                             DateTime AV8cfechaCompra ,
                                             decimal AV9cporcentajeIVACompra ,
                                             short AV10cidProveedor ,
                                             short A38tipoFacturaCompra ,
                                             DateTime A43fechaCompra ,
                                             decimal A44porcentajeIVACompra ,
                                             short A2idProveedor ,
                                             short AV6cidCompra )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Compra]";
         scmdbuf = scmdbuf + " WHERE ([idCompra] >= @AV6cidCompra)";
         if ( ! (0==AV7ctipoFacturaCompra) )
         {
            sWhereString = sWhereString + " and ([tipoFacturaCompra] >= @AV7ctipoFacturaCompra)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV8cfechaCompra) )
         {
            sWhereString = sWhereString + " and ([fechaCompra] >= @AV8cfechaCompra)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cporcentajeIVACompra) )
         {
            sWhereString = sWhereString + " and ([porcentajeIVACompra] >= @AV9cporcentajeIVACompra)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cidProveedor) )
         {
            sWhereString = sWhereString + " and ([idProveedor] >= @AV10cidProveedor)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000F2(context, (short)dynConstraints[0] , (DateTime)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (DateTime)dynConstraints[5] , (decimal)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] );
               case 1 :
                     return conditional_H000F3(context, (short)dynConstraints[0] , (DateTime)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (DateTime)dynConstraints[5] , (decimal)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000F2 ;
          prmH000F2 = new Object[] {
          new Object[] {"@AV6cidCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7ctipoFacturaCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cfechaCompra",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cporcentajeIVACompra",SqlDbType.Decimal,3,2} ,
          new Object[] {"@AV10cidProveedor",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000F3 ;
          prmH000F3 = new Object[] {
          new Object[] {"@AV6cidCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7ctipoFacturaCompra",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cfechaCompra",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cporcentajeIVACompra",SqlDbType.Decimal,3,2} ,
          new Object[] {"@AV10cidProveedor",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F2,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H000F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F3,1, GxCacheFrequency.OFF ,false,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                return;
       }
    }

 }

}
