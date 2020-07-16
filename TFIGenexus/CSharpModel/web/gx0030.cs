/*
               File: Gx0030
        Description: Selection List Producto
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:2:56.26
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
   public class gx0030 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0030( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0030( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pidProducto )
      {
         this.AV12pidProducto = 0 ;
         executePrivate();
         aP0_pidProducto=this.AV12pidProducto;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCtipoproducto = new GXCombobox();
         cmbtipoProducto = new GXCombobox();
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
               nRC_GXsfl_74 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
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
               AV6cidProducto = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cdescripcionProducto = GetNextPar( );
               AV8cstockProducto = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cprecioProducto = NumberUtil.Val( GetNextPar( ), ".");
               AV10ctipoProducto = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11cstockSeguridad = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cidProducto, AV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad) ;
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
               AV12pidProducto = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV12pidProducto", StringUtil.LTrimStr( (decimal)(AV12pidProducto), 4, 0));
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
         PA0A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0A2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20207161325632", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0030.aspx") + "?" + UrlEncode("" +AV12pidProducto)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCIDPRODUCTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cidProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDESCRIPCIONPRODUCTO", AV7cdescripcionProducto);
         GxWebStd.gx_hidden_field( context, "GXH_vCSTOCKPRODUCTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cstockProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRECIOPRODUCTO", StringUtil.LTrim( StringUtil.NToC( AV9cprecioProducto, 10, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPRODUCTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ctipoProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSTOCKSEGURIDAD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cstockSeguridad), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPIDPRODUCTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pidProducto), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "IDPRODUCTOFILTERCONTAINER_Class", StringUtil.RTrim( divIdproductofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DESCRIPCIONPRODUCTOFILTERCONTAINER_Class", StringUtil.RTrim( divDescripcionproductofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STOCKPRODUCTOFILTERCONTAINER_Class", StringUtil.RTrim( divStockproductofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PRECIOPRODUCTOFILTERCONTAINER_Class", StringUtil.RTrim( divPrecioproductofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOPRODUCTOFILTERCONTAINER_Class", StringUtil.RTrim( divTipoproductofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "STOCKSEGURIDADFILTERCONTAINER_Class", StringUtil.RTrim( divStockseguridadfiltercontainer_Class));
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
            WE0A2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0A2( ) ;
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
         return formatLink("gx0030.aspx") + "?" + UrlEncode("" +AV12pidProducto) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0030" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Producto" ;
      }

      protected void WB0A0( )
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
            GxWebStd.gx_div_start( context, divIdproductofiltercontainer_Internalname, 1, 0, "px", 0, "px", divIdproductofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblidproductofilter_Internalname, "id Producto", "", "", lblLblidproductofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCidproducto_Internalname, "id Producto", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCidproducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cidProducto), 4, 0, ".", "")), ((edtavCidproducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cidProducto), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cidProducto), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCidproducto_Jsonclick, 0, "Attribute", "", "", "", "", edtavCidproducto_Visible, edtavCidproducto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divDescripcionproductofiltercontainer_Internalname, 1, 0, "px", 0, "px", divDescripcionproductofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldescripcionproductofilter_Internalname, "descripcion Producto", "", "", lblLbldescripcionproductofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdescripcionproducto_Internalname, "descripcion Producto", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdescripcionproducto_Internalname, AV7cdescripcionProducto, StringUtil.RTrim( context.localUtil.Format( AV7cdescripcionProducto, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdescripcionproducto_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdescripcionproducto_Visible, edtavCdescripcionproducto_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divStockproductofiltercontainer_Internalname, 1, 0, "px", 0, "px", divStockproductofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstockproductofilter_Internalname, "stock Producto", "", "", lblLblstockproductofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstockproducto_Internalname, "stock Producto", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstockproducto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cstockProducto), 4, 0, ".", "")), ((edtavCstockproducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cstockProducto), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cstockProducto), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstockproducto_Jsonclick, 0, "Attribute", "", "", "", "", edtavCstockproducto_Visible, edtavCstockproducto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divPrecioproductofiltercontainer_Internalname, 1, 0, "px", 0, "px", divPrecioproductofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblprecioproductofilter_Internalname, "precio Producto", "", "", lblLblprecioproductofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCprecioproducto_Internalname, "precio Producto", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCprecioproducto_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cprecioProducto, 10, 2, ".", "")), ((edtavCprecioproducto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cprecioProducto, "ZZZZZZ9.99")) : context.localUtil.Format( AV9cprecioProducto, "ZZZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCprecioproducto_Jsonclick, 0, "Attribute", "", "", "", "", edtavCprecioproducto_Visible, edtavCprecioproducto_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divTipoproductofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoproductofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoproductofilter_Internalname, "tipo Producto", "", "", lblLbltipoproductofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCtipoproducto_Internalname, "tipo Producto", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipoproducto, cmbavCtipoproducto_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV10ctipoProducto), 4, 0)), 1, cmbavCtipoproducto_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCtipoproducto.Visible, cmbavCtipoproducto.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "", true, "HLP_Gx0030.htm");
            cmbavCtipoproducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10ctipoProducto), 4, 0));
            AssignProp("", false, cmbavCtipoproducto_Internalname, "Values", (String)(cmbavCtipoproducto.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divStockseguridadfiltercontainer_Internalname, 1, 0, "px", 0, "px", divStockseguridadfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblstockseguridadfilter_Internalname, "stock Seguridad", "", "", lblLblstockseguridadfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160a1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCstockseguridad_Internalname, "stock Seguridad", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCstockseguridad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cstockSeguridad), 4, 0, ".", "")), ((edtavCstockseguridad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cstockSeguridad), "ZZZ9")) : context.localUtil.Format( (decimal)(AV11cstockSeguridad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCstockseguridad_Jsonclick, 0, "Attribute", "", "", "", "", edtavCstockseguridad_Visible, edtavCstockseguridad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0030.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e170a1_client"+"'", TempTags, "", 2, "HLP_Gx0030.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
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
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A19descripcionProducto);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtdescripcionProducto_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20stockProducto), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22tipoProducto), 4, 0, ".", "")));
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
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (int)(nGXsfl_74_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 74 )
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

      protected void START0A2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_8-139369", 0) ;
            Form.Meta.addItem("description", "Selection List Producto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0A0( ) ;
      }

      protected void WS0A2( )
      {
         START0A2( ) ;
         EVT0A2( ) ;
      }

      protected void EVT0A2( )
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
                              nGXsfl_74_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A3idProducto = (short)(context.localUtil.CToN( cgiGet( edtidProducto_Internalname), ".", ","));
                              A19descripcionProducto = cgiGet( edtdescripcionProducto_Internalname);
                              A20stockProducto = (short)(context.localUtil.CToN( cgiGet( edtstockProducto_Internalname), ".", ","));
                              A21precioProducto = context.localUtil.CToN( cgiGet( edtprecioProducto_Internalname), ".", ",");
                              cmbtipoProducto.Name = cmbtipoProducto_Internalname;
                              cmbtipoProducto.CurrentValue = cgiGet( cmbtipoProducto_Internalname);
                              A22tipoProducto = (short)(NumberUtil.Val( cgiGet( cmbtipoProducto_Internalname), "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E180A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E190A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cidproducto Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCIDPRODUCTO"), ".", ",") != Convert.ToDecimal( AV6cidProducto )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdescripcionproducto Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCDESCRIPCIONPRODUCTO"), AV7cdescripcionProducto) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstockproducto Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSTOCKPRODUCTO"), ".", ",") != Convert.ToDecimal( AV8cstockProducto )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cprecioproducto Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPRECIOPRODUCTO"), ".", ",") != AV9cprecioProducto )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoproducto Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPRODUCTO"), ".", ",") != Convert.ToDecimal( AV10ctipoProducto )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cstockseguridad Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSTOCKSEGURIDAD"), ".", ",") != Convert.ToDecimal( AV11cstockSeguridad )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E200A2 ();
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

      protected void WE0A2( )
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

      protected void PA0A2( )
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
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cidProducto ,
                                        String AV7cdescripcionProducto ,
                                        short AV8cstockProducto ,
                                        decimal AV9cprecioProducto ,
                                        short AV10ctipoProducto ,
                                        short AV11cstockSeguridad )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF0A2( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         send_integrity_footer_hashes( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_IDPRODUCTO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "IDPRODUCTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")));
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
         if ( cmbavCtipoproducto.ItemCount > 0 )
         {
            AV10ctipoProducto = (short)(NumberUtil.Val( cmbavCtipoproducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10ctipoProducto), 4, 0))), "."));
            AssignAttri("", false, "AV10ctipoProducto", StringUtil.LTrimStr( (decimal)(AV10ctipoProducto), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCtipoproducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10ctipoProducto), 4, 0));
            AssignProp("", false, cmbavCtipoproducto_Internalname, "Values", cmbavCtipoproducto.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0A2( ) ;
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

      protected void RF0A2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
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
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cdescripcionProducto ,
                                                 AV8cstockProducto ,
                                                 AV9cprecioProducto ,
                                                 AV10ctipoProducto ,
                                                 AV11cstockSeguridad ,
                                                 A19descripcionProducto ,
                                                 A20stockProducto ,
                                                 A21precioProducto ,
                                                 A22tipoProducto ,
                                                 A23stockSeguridad ,
                                                 AV6cidProducto } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT
                                                 }
            } ) ;
            lV7cdescripcionProducto = StringUtil.Concat( StringUtil.RTrim( AV7cdescripcionProducto), "%", "");
            /* Using cursor H000A2 */
            pr_default.execute(0, new Object[] {AV6cidProducto, lV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A23stockSeguridad = H000A2_A23stockSeguridad[0];
               A22tipoProducto = H000A2_A22tipoProducto[0];
               A21precioProducto = H000A2_A21precioProducto[0];
               A20stockProducto = H000A2_A20stockProducto[0];
               A19descripcionProducto = H000A2_A19descripcionProducto[0];
               A3idProducto = H000A2_A3idProducto[0];
               /* Execute user event: Load */
               E190A2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB0A0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0A2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_IDPRODUCTO"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9"), context));
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
                                              AV7cdescripcionProducto ,
                                              AV8cstockProducto ,
                                              AV9cprecioProducto ,
                                              AV10ctipoProducto ,
                                              AV11cstockSeguridad ,
                                              A19descripcionProducto ,
                                              A20stockProducto ,
                                              A21precioProducto ,
                                              A22tipoProducto ,
                                              A23stockSeguridad ,
                                              AV6cidProducto } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT
                                              }
         } ) ;
         lV7cdescripcionProducto = StringUtil.Concat( StringUtil.RTrim( AV7cdescripcionProducto), "%", "");
         /* Using cursor H000A3 */
         pr_default.execute(1, new Object[] {AV6cidProducto, lV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad});
         GRID1_nRecordCount = H000A3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidProducto, AV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidProducto, AV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidProducto, AV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidProducto, AV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cidProducto, AV7cdescripcionProducto, AV8cstockProducto, AV9cprecioProducto, AV10ctipoProducto, AV11cstockSeguridad) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP0A0( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E180A2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_74 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ".", ","));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCidproducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCidproducto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCIDPRODUCTO");
               GX_FocusControl = edtavCidproducto_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cidProducto = 0;
               AssignAttri("", false, "AV6cidProducto", StringUtil.LTrimStr( (decimal)(AV6cidProducto), 4, 0));
            }
            else
            {
               AV6cidProducto = (short)(context.localUtil.CToN( cgiGet( edtavCidproducto_Internalname), ".", ","));
               AssignAttri("", false, "AV6cidProducto", StringUtil.LTrimStr( (decimal)(AV6cidProducto), 4, 0));
            }
            AV7cdescripcionProducto = cgiGet( edtavCdescripcionproducto_Internalname);
            AssignAttri("", false, "AV7cdescripcionProducto", AV7cdescripcionProducto);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCstockproducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCstockproducto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSTOCKPRODUCTO");
               GX_FocusControl = edtavCstockproducto_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cstockProducto = 0;
               AssignAttri("", false, "AV8cstockProducto", StringUtil.LTrimStr( (decimal)(AV8cstockProducto), 4, 0));
            }
            else
            {
               AV8cstockProducto = (short)(context.localUtil.CToN( cgiGet( edtavCstockproducto_Internalname), ".", ","));
               AssignAttri("", false, "AV8cstockProducto", StringUtil.LTrimStr( (decimal)(AV8cstockProducto), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCprecioproducto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCprecioproducto_Internalname), ".", ",") > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPRECIOPRODUCTO");
               GX_FocusControl = edtavCprecioproducto_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cprecioProducto = 0;
               AssignAttri("", false, "AV9cprecioProducto", StringUtil.LTrimStr( AV9cprecioProducto, 10, 2));
            }
            else
            {
               AV9cprecioProducto = context.localUtil.CToN( cgiGet( edtavCprecioproducto_Internalname), ".", ",");
               AssignAttri("", false, "AV9cprecioProducto", StringUtil.LTrimStr( AV9cprecioProducto, 10, 2));
            }
            cmbavCtipoproducto.Name = cmbavCtipoproducto_Internalname;
            cmbavCtipoproducto.CurrentValue = cgiGet( cmbavCtipoproducto_Internalname);
            AV10ctipoProducto = (short)(NumberUtil.Val( cgiGet( cmbavCtipoproducto_Internalname), "."));
            AssignAttri("", false, "AV10ctipoProducto", StringUtil.LTrimStr( (decimal)(AV10ctipoProducto), 4, 0));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCstockseguridad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCstockseguridad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSTOCKSEGURIDAD");
               GX_FocusControl = edtavCstockseguridad_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cstockSeguridad = 0;
               AssignAttri("", false, "AV11cstockSeguridad", StringUtil.LTrimStr( (decimal)(AV11cstockSeguridad), 4, 0));
            }
            else
            {
               AV11cstockSeguridad = (short)(context.localUtil.CToN( cgiGet( edtavCstockseguridad_Internalname), ".", ","));
               AssignAttri("", false, "AV11cstockSeguridad", StringUtil.LTrimStr( (decimal)(AV11cstockSeguridad), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCIDPRODUCTO"), ".", ",") != Convert.ToDecimal( AV6cidProducto )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCDESCRIPCIONPRODUCTO"), AV7cdescripcionProducto) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSTOCKPRODUCTO"), ".", ",") != Convert.ToDecimal( AV8cstockProducto )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCPRECIOPRODUCTO"), ".", ",") != AV9cprecioProducto )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPRODUCTO"), ".", ",") != Convert.ToDecimal( AV10ctipoProducto )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSTOCKSEGURIDAD"), ".", ",") != Convert.ToDecimal( AV11cstockSeguridad )) )
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
         E180A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E180A2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Producto", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E190A2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV16Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E200A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E200A2( )
      {
         /* Enter Routine */
         AV12pidProducto = A3idProducto;
         AssignAttri("", false, "AV12pidProducto", StringUtil.LTrimStr( (decimal)(AV12pidProducto), 4, 0));
         context.setWebReturnParms(new Object[] {(short)AV12pidProducto});
         context.setWebReturnParmsMetadata(new Object[] {"AV12pidProducto"});
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
         AV12pidProducto = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV12pidProducto", StringUtil.LTrimStr( (decimal)(AV12pidProducto), 4, 0));
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
         PA0A2( ) ;
         WS0A2( ) ;
         WE0A2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20207161325684", true, true);
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
         context.AddJavascriptSource("gx0030.js", "?20207161325684", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtidProducto_Internalname = "IDPRODUCTO_"+sGXsfl_74_idx;
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO_"+sGXsfl_74_idx;
         edtstockProducto_Internalname = "STOCKPRODUCTO_"+sGXsfl_74_idx;
         edtprecioProducto_Internalname = "PRECIOPRODUCTO_"+sGXsfl_74_idx;
         cmbtipoProducto_Internalname = "TIPOPRODUCTO_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtidProducto_Internalname = "IDPRODUCTO_"+sGXsfl_74_fel_idx;
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO_"+sGXsfl_74_fel_idx;
         edtstockProducto_Internalname = "STOCKPRODUCTO_"+sGXsfl_74_fel_idx;
         edtprecioProducto_Internalname = "PRECIOPRODUCTO_"+sGXsfl_74_fel_idx;
         cmbtipoProducto_Internalname = "TIPOPRODUCTO_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB0A0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtidProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A3idProducto), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtidProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtdescripcionProducto_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3idProducto), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtdescripcionProducto_Internalname, "Link", edtdescripcionProducto_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdescripcionProducto_Internalname,(String)A19descripcionProducto,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtdescripcionProducto_Link,(String)"",(String)"",(String)"",(String)edtdescripcionProducto_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A20stockProducto), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A20stockProducto), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprecioProducto_Internalname,StringUtil.LTrim( StringUtil.NToC( A21precioProducto, 10, 2, ".", "")),context.localUtil.Format( A21precioProducto, "ZZZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprecioProducto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Precio",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbtipoProducto.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOPRODUCTO_" + sGXsfl_74_idx;
               cmbtipoProducto.Name = GXCCtl;
               cmbtipoProducto.WebTags = "";
               cmbtipoProducto.addItem("0", "Producto de Compra", 0);
               cmbtipoProducto.addItem("1", "Producto de Venta", 0);
               if ( cmbtipoProducto.ItemCount > 0 )
               {
                  A22tipoProducto = (short)(NumberUtil.Val( cmbtipoProducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0))), "."));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbtipoProducto,(String)cmbtipoProducto_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0)),(short)1,(String)cmbtipoProducto_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbtipoProducto.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0));
            AssignProp("", false, cmbtipoProducto_Internalname, "Values", (String)(cmbtipoProducto.ToJavascriptSource()), !bGXsfl_74_Refreshing);
            send_integrity_lvl_hashes0A2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         cmbavCtipoproducto.Name = "vCTIPOPRODUCTO";
         cmbavCtipoproducto.WebTags = "";
         cmbavCtipoproducto.addItem("0", "Producto de Compra", 0);
         cmbavCtipoproducto.addItem("1", "Producto de Venta", 0);
         if ( cmbavCtipoproducto.ItemCount > 0 )
         {
            AV10ctipoProducto = (short)(NumberUtil.Val( cmbavCtipoproducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10ctipoProducto), 4, 0))), "."));
            AssignAttri("", false, "AV10ctipoProducto", StringUtil.LTrimStr( (decimal)(AV10ctipoProducto), 4, 0));
         }
         GXCCtl = "TIPOPRODUCTO_" + sGXsfl_74_idx;
         cmbtipoProducto.Name = GXCCtl;
         cmbtipoProducto.WebTags = "";
         cmbtipoProducto.addItem("0", "Producto de Compra", 0);
         cmbtipoProducto.addItem("1", "Producto de Venta", 0);
         if ( cmbtipoProducto.ItemCount > 0 )
         {
            A22tipoProducto = (short)(NumberUtil.Val( cmbtipoProducto.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22tipoProducto), 4, 0))), "."));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblidproductofilter_Internalname = "LBLIDPRODUCTOFILTER";
         edtavCidproducto_Internalname = "vCIDPRODUCTO";
         divIdproductofiltercontainer_Internalname = "IDPRODUCTOFILTERCONTAINER";
         lblLbldescripcionproductofilter_Internalname = "LBLDESCRIPCIONPRODUCTOFILTER";
         edtavCdescripcionproducto_Internalname = "vCDESCRIPCIONPRODUCTO";
         divDescripcionproductofiltercontainer_Internalname = "DESCRIPCIONPRODUCTOFILTERCONTAINER";
         lblLblstockproductofilter_Internalname = "LBLSTOCKPRODUCTOFILTER";
         edtavCstockproducto_Internalname = "vCSTOCKPRODUCTO";
         divStockproductofiltercontainer_Internalname = "STOCKPRODUCTOFILTERCONTAINER";
         lblLblprecioproductofilter_Internalname = "LBLPRECIOPRODUCTOFILTER";
         edtavCprecioproducto_Internalname = "vCPRECIOPRODUCTO";
         divPrecioproductofiltercontainer_Internalname = "PRECIOPRODUCTOFILTERCONTAINER";
         lblLbltipoproductofilter_Internalname = "LBLTIPOPRODUCTOFILTER";
         cmbavCtipoproducto_Internalname = "vCTIPOPRODUCTO";
         divTipoproductofiltercontainer_Internalname = "TIPOPRODUCTOFILTERCONTAINER";
         lblLblstockseguridadfilter_Internalname = "LBLSTOCKSEGURIDADFILTER";
         edtavCstockseguridad_Internalname = "vCSTOCKSEGURIDAD";
         divStockseguridadfiltercontainer_Internalname = "STOCKSEGURIDADFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtidProducto_Internalname = "IDPRODUCTO";
         edtdescripcionProducto_Internalname = "DESCRIPCIONPRODUCTO";
         edtstockProducto_Internalname = "STOCKPRODUCTO";
         edtprecioProducto_Internalname = "PRECIOPRODUCTO";
         cmbtipoProducto_Internalname = "TIPOPRODUCTO";
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
         cmbtipoProducto_Jsonclick = "";
         edtprecioProducto_Jsonclick = "";
         edtstockProducto_Jsonclick = "";
         edtdescripcionProducto_Jsonclick = "";
         edtidProducto_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtdescripcionProducto_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCstockseguridad_Jsonclick = "";
         edtavCstockseguridad_Enabled = 1;
         edtavCstockseguridad_Visible = 1;
         cmbavCtipoproducto_Jsonclick = "";
         cmbavCtipoproducto.Enabled = 1;
         cmbavCtipoproducto.Visible = 1;
         edtavCprecioproducto_Jsonclick = "";
         edtavCprecioproducto_Enabled = 1;
         edtavCprecioproducto_Visible = 1;
         edtavCstockproducto_Jsonclick = "";
         edtavCstockproducto_Enabled = 1;
         edtavCstockproducto_Visible = 1;
         edtavCdescripcionproducto_Jsonclick = "";
         edtavCdescripcionproducto_Enabled = 1;
         edtavCdescripcionproducto_Visible = 1;
         edtavCidproducto_Jsonclick = "";
         edtavCidproducto_Enabled = 1;
         edtavCidproducto_Visible = 1;
         divStockseguridadfiltercontainer_Class = "AdvancedContainerItem";
         divTipoproductofiltercontainer_Class = "AdvancedContainerItem";
         divPrecioproductofiltercontainer_Class = "AdvancedContainerItem";
         divStockproductofiltercontainer_Class = "AdvancedContainerItem";
         divDescripcionproductofiltercontainer_Class = "AdvancedContainerItem";
         divIdproductofiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Producto";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidProducto',fld:'vCIDPRODUCTO',pic:'ZZZ9'},{av:'AV7cdescripcionProducto',fld:'vCDESCRIPCIONPRODUCTO',pic:''},{av:'AV8cstockProducto',fld:'vCSTOCKPRODUCTO',pic:'ZZZ9'},{av:'AV9cprecioProducto',fld:'vCPRECIOPRODUCTO',pic:'ZZZZZZ9.99'},{av:'cmbavCtipoproducto'},{av:'AV10ctipoProducto',fld:'vCTIPOPRODUCTO',pic:'ZZZ9'},{av:'AV11cstockSeguridad',fld:'vCSTOCKSEGURIDAD',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E170A1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLIDPRODUCTOFILTER.CLICK","{handler:'E110A1',iparms:[{av:'divIdproductofiltercontainer_Class',ctrl:'IDPRODUCTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLIDPRODUCTOFILTER.CLICK",",oparms:[{av:'divIdproductofiltercontainer_Class',ctrl:'IDPRODUCTOFILTERCONTAINER',prop:'Class'},{av:'edtavCidproducto_Visible',ctrl:'vCIDPRODUCTO',prop:'Visible'}]}");
         setEventMetadata("LBLDESCRIPCIONPRODUCTOFILTER.CLICK","{handler:'E120A1',iparms:[{av:'divDescripcionproductofiltercontainer_Class',ctrl:'DESCRIPCIONPRODUCTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDESCRIPCIONPRODUCTOFILTER.CLICK",",oparms:[{av:'divDescripcionproductofiltercontainer_Class',ctrl:'DESCRIPCIONPRODUCTOFILTERCONTAINER',prop:'Class'},{av:'edtavCdescripcionproducto_Visible',ctrl:'vCDESCRIPCIONPRODUCTO',prop:'Visible'}]}");
         setEventMetadata("LBLSTOCKPRODUCTOFILTER.CLICK","{handler:'E130A1',iparms:[{av:'divStockproductofiltercontainer_Class',ctrl:'STOCKPRODUCTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSTOCKPRODUCTOFILTER.CLICK",",oparms:[{av:'divStockproductofiltercontainer_Class',ctrl:'STOCKPRODUCTOFILTERCONTAINER',prop:'Class'},{av:'edtavCstockproducto_Visible',ctrl:'vCSTOCKPRODUCTO',prop:'Visible'}]}");
         setEventMetadata("LBLPRECIOPRODUCTOFILTER.CLICK","{handler:'E140A1',iparms:[{av:'divPrecioproductofiltercontainer_Class',ctrl:'PRECIOPRODUCTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLPRECIOPRODUCTOFILTER.CLICK",",oparms:[{av:'divPrecioproductofiltercontainer_Class',ctrl:'PRECIOPRODUCTOFILTERCONTAINER',prop:'Class'},{av:'edtavCprecioproducto_Visible',ctrl:'vCPRECIOPRODUCTO',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOPRODUCTOFILTER.CLICK","{handler:'E150A1',iparms:[{av:'divTipoproductofiltercontainer_Class',ctrl:'TIPOPRODUCTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOPRODUCTOFILTER.CLICK",",oparms:[{av:'divTipoproductofiltercontainer_Class',ctrl:'TIPOPRODUCTOFILTERCONTAINER',prop:'Class'},{av:'cmbavCtipoproducto'}]}");
         setEventMetadata("LBLSTOCKSEGURIDADFILTER.CLICK","{handler:'E160A1',iparms:[{av:'divStockseguridadfiltercontainer_Class',ctrl:'STOCKSEGURIDADFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSTOCKSEGURIDADFILTER.CLICK",",oparms:[{av:'divStockseguridadfiltercontainer_Class',ctrl:'STOCKSEGURIDADFILTERCONTAINER',prop:'Class'},{av:'edtavCstockseguridad_Visible',ctrl:'vCSTOCKSEGURIDAD',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E200A2',iparms:[{av:'A3idProducto',fld:'IDPRODUCTO',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV12pidProducto',fld:'vPIDPRODUCTO',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidProducto',fld:'vCIDPRODUCTO',pic:'ZZZ9'},{av:'AV7cdescripcionProducto',fld:'vCDESCRIPCIONPRODUCTO',pic:''},{av:'AV8cstockProducto',fld:'vCSTOCKPRODUCTO',pic:'ZZZ9'},{av:'AV9cprecioProducto',fld:'vCPRECIOPRODUCTO',pic:'ZZZZZZ9.99'},{av:'cmbavCtipoproducto'},{av:'AV10ctipoProducto',fld:'vCTIPOPRODUCTO',pic:'ZZZ9'},{av:'AV11cstockSeguridad',fld:'vCSTOCKSEGURIDAD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidProducto',fld:'vCIDPRODUCTO',pic:'ZZZ9'},{av:'AV7cdescripcionProducto',fld:'vCDESCRIPCIONPRODUCTO',pic:''},{av:'AV8cstockProducto',fld:'vCSTOCKPRODUCTO',pic:'ZZZ9'},{av:'AV9cprecioProducto',fld:'vCPRECIOPRODUCTO',pic:'ZZZZZZ9.99'},{av:'cmbavCtipoproducto'},{av:'AV10ctipoProducto',fld:'vCTIPOPRODUCTO',pic:'ZZZ9'},{av:'AV11cstockSeguridad',fld:'vCSTOCKSEGURIDAD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidProducto',fld:'vCIDPRODUCTO',pic:'ZZZ9'},{av:'AV7cdescripcionProducto',fld:'vCDESCRIPCIONPRODUCTO',pic:''},{av:'AV8cstockProducto',fld:'vCSTOCKPRODUCTO',pic:'ZZZ9'},{av:'AV9cprecioProducto',fld:'vCPRECIOPRODUCTO',pic:'ZZZZZZ9.99'},{av:'cmbavCtipoproducto'},{av:'AV10ctipoProducto',fld:'vCTIPOPRODUCTO',pic:'ZZZ9'},{av:'AV11cstockSeguridad',fld:'vCSTOCKSEGURIDAD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cidProducto',fld:'vCIDPRODUCTO',pic:'ZZZ9'},{av:'AV7cdescripcionProducto',fld:'vCDESCRIPCIONPRODUCTO',pic:''},{av:'AV8cstockProducto',fld:'vCSTOCKPRODUCTO',pic:'ZZZ9'},{av:'AV9cprecioProducto',fld:'vCPRECIOPRODUCTO',pic:'ZZZZZZ9.99'},{av:'cmbavCtipoproducto'},{av:'AV10ctipoProducto',fld:'vCTIPOPRODUCTO',pic:'ZZZ9'},{av:'AV11cstockSeguridad',fld:'vCSTOCKSEGURIDAD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("VALIDV_CTIPOPRODUCTO","{handler:'Validv_Ctipoproducto',iparms:[]");
         setEventMetadata("VALIDV_CTIPOPRODUCTO",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Tipoproducto',iparms:[]");
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
         AV7cdescripcionProducto = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblidproductofilter_Jsonclick = "";
         TempTags = "";
         lblLbldescripcionproductofilter_Jsonclick = "";
         lblLblstockproductofilter_Jsonclick = "";
         lblLblprecioproductofilter_Jsonclick = "";
         lblLbltipoproductofilter_Jsonclick = "";
         lblLblstockseguridadfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A19descripcionProducto = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         scmdbuf = "";
         lV7cdescripcionProducto = "";
         H000A2_A23stockSeguridad = new short[1] ;
         H000A2_A22tipoProducto = new short[1] ;
         H000A2_A21precioProducto = new decimal[1] ;
         H000A2_A20stockProducto = new short[1] ;
         H000A2_A19descripcionProducto = new String[] {""} ;
         H000A2_A3idProducto = new short[1] ;
         H000A3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0030__default(),
            new Object[][] {
                new Object[] {
               H000A2_A23stockSeguridad, H000A2_A22tipoProducto, H000A2_A21precioProducto, H000A2_A20stockProducto, H000A2_A19descripcionProducto, H000A2_A3idProducto
               }
               , new Object[] {
               H000A3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GRID1_nEOF ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV6cidProducto ;
      private short AV8cstockProducto ;
      private short AV10ctipoProducto ;
      private short AV11cstockSeguridad ;
      private short AV12pidProducto ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A3idProducto ;
      private short A20stockProducto ;
      private short A22tipoProducto ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A23stockSeguridad ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_74 ;
      private int nGXsfl_74_idx=1 ;
      private int subGrid1_Rows ;
      private int edtavCidproducto_Enabled ;
      private int edtavCidproducto_Visible ;
      private int edtavCdescripcionproducto_Visible ;
      private int edtavCdescripcionproducto_Enabled ;
      private int edtavCstockproducto_Enabled ;
      private int edtavCstockproducto_Visible ;
      private int edtavCprecioproducto_Enabled ;
      private int edtavCprecioproducto_Visible ;
      private int edtavCstockseguridad_Enabled ;
      private int edtavCstockseguridad_Visible ;
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
      private decimal AV9cprecioProducto ;
      private decimal A21precioProducto ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divIdproductofiltercontainer_Class ;
      private String divDescripcionproductofiltercontainer_Class ;
      private String divStockproductofiltercontainer_Class ;
      private String divPrecioproductofiltercontainer_Class ;
      private String divTipoproductofiltercontainer_Class ;
      private String divStockseguridadfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divIdproductofiltercontainer_Internalname ;
      private String lblLblidproductofilter_Internalname ;
      private String lblLblidproductofilter_Jsonclick ;
      private String edtavCidproducto_Internalname ;
      private String TempTags ;
      private String edtavCidproducto_Jsonclick ;
      private String divDescripcionproductofiltercontainer_Internalname ;
      private String lblLbldescripcionproductofilter_Internalname ;
      private String lblLbldescripcionproductofilter_Jsonclick ;
      private String edtavCdescripcionproducto_Internalname ;
      private String edtavCdescripcionproducto_Jsonclick ;
      private String divStockproductofiltercontainer_Internalname ;
      private String lblLblstockproductofilter_Internalname ;
      private String lblLblstockproductofilter_Jsonclick ;
      private String edtavCstockproducto_Internalname ;
      private String edtavCstockproducto_Jsonclick ;
      private String divPrecioproductofiltercontainer_Internalname ;
      private String lblLblprecioproductofilter_Internalname ;
      private String lblLblprecioproductofilter_Jsonclick ;
      private String edtavCprecioproducto_Internalname ;
      private String edtavCprecioproducto_Jsonclick ;
      private String divTipoproductofiltercontainer_Internalname ;
      private String lblLbltipoproductofilter_Internalname ;
      private String lblLbltipoproductofilter_Jsonclick ;
      private String cmbavCtipoproducto_Internalname ;
      private String cmbavCtipoproducto_Jsonclick ;
      private String divStockseguridadfiltercontainer_Internalname ;
      private String lblLblstockseguridadfilter_Internalname ;
      private String lblLblstockseguridadfilter_Jsonclick ;
      private String edtavCstockseguridad_Internalname ;
      private String edtavCstockseguridad_Jsonclick ;
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
      private String edtdescripcionProducto_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtidProducto_Internalname ;
      private String edtdescripcionProducto_Internalname ;
      private String edtstockProducto_Internalname ;
      private String edtprecioProducto_Internalname ;
      private String cmbtipoProducto_Internalname ;
      private String scmdbuf ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtidProducto_Jsonclick ;
      private String edtdescripcionProducto_Jsonclick ;
      private String edtstockProducto_Jsonclick ;
      private String edtprecioProducto_Jsonclick ;
      private String GXCCtl ;
      private String cmbtipoProducto_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cdescripcionProducto ;
      private String A19descripcionProducto ;
      private String AV16Linkselection_GXI ;
      private String lV7cdescripcionProducto ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCtipoproducto ;
      private GXCombobox cmbtipoProducto ;
      private IDataStoreProvider pr_default ;
      private short[] H000A2_A23stockSeguridad ;
      private short[] H000A2_A22tipoProducto ;
      private decimal[] H000A2_A21precioProducto ;
      private short[] H000A2_A20stockProducto ;
      private String[] H000A2_A19descripcionProducto ;
      private short[] H000A2_A3idProducto ;
      private long[] H000A3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pidProducto ;
      private GXWebForm Form ;
   }

   public class gx0030__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000A2( IGxContext context ,
                                             String AV7cdescripcionProducto ,
                                             short AV8cstockProducto ,
                                             decimal AV9cprecioProducto ,
                                             short AV10ctipoProducto ,
                                             short AV11cstockSeguridad ,
                                             String A19descripcionProducto ,
                                             short A20stockProducto ,
                                             decimal A21precioProducto ,
                                             short A22tipoProducto ,
                                             short A23stockSeguridad ,
                                             short AV6cidProducto )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [stockSeguridad], [tipoProducto], [precioProducto], [stockProducto], [descripcionProducto], [idProducto]";
         sFromString = " FROM [Producto]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([idProducto] >= @AV6cidProducto)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cdescripcionProducto)) )
         {
            sWhereString = sWhereString + " and ([descripcionProducto] like @lV7cdescripcionProducto)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cstockProducto) )
         {
            sWhereString = sWhereString + " and ([stockProducto] >= @AV8cstockProducto)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cprecioProducto) )
         {
            sWhereString = sWhereString + " and ([precioProducto] >= @AV9cprecioProducto)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10ctipoProducto) )
         {
            sWhereString = sWhereString + " and ([tipoProducto] >= @AV10ctipoProducto)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cstockSeguridad) )
         {
            sWhereString = sWhereString + " and ([stockSeguridad] >= @AV11cstockSeguridad)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [idProducto]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000A3( IGxContext context ,
                                             String AV7cdescripcionProducto ,
                                             short AV8cstockProducto ,
                                             decimal AV9cprecioProducto ,
                                             short AV10ctipoProducto ,
                                             short AV11cstockSeguridad ,
                                             String A19descripcionProducto ,
                                             short A20stockProducto ,
                                             decimal A21precioProducto ,
                                             short A22tipoProducto ,
                                             short A23stockSeguridad ,
                                             short AV6cidProducto )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Producto]";
         scmdbuf = scmdbuf + " WHERE ([idProducto] >= @AV6cidProducto)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cdescripcionProducto)) )
         {
            sWhereString = sWhereString + " and ([descripcionProducto] like @lV7cdescripcionProducto)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cstockProducto) )
         {
            sWhereString = sWhereString + " and ([stockProducto] >= @AV8cstockProducto)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cprecioProducto) )
         {
            sWhereString = sWhereString + " and ([precioProducto] >= @AV9cprecioProducto)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10ctipoProducto) )
         {
            sWhereString = sWhereString + " and ([tipoProducto] >= @AV10ctipoProducto)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cstockSeguridad) )
         {
            sWhereString = sWhereString + " and ([stockSeguridad] >= @AV11cstockSeguridad)";
         }
         else
         {
            GXv_int3[5] = 1;
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
                     return conditional_H000A2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (decimal)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H000A3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (decimal)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
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
          Object[] prmH000A2 ;
          prmH000A2 = new Object[] {
          new Object[] {"@AV6cidProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cdescripcionProducto",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@AV8cstockProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cprecioProducto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV10ctipoProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cstockSeguridad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000A3 ;
          prmH000A3 = new Object[] {
          new Object[] {"@AV6cidProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cdescripcionProducto",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@AV8cstockProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cprecioProducto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV10ctipoProducto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cstockSeguridad",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000A2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000A2,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H000A3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000A3,1, GxCacheFrequency.OFF ,false,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                return;
       }
    }

 }

}
