/*
               File: VentaConversion
        Description: Conversion for table Venta
             Author: GeneXus C# Generator version 16_0_8-139369
       Generated on: 7/16/2020 13:11:59.8
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class ventaconversion : GXProcedure
   {
      public ventaconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ventaconversion( IGxContext context )
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
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         ventaconversion objventaconversion;
         objventaconversion = new ventaconversion();
         objventaconversion.context.SetSubmitInitialConfig(context);
         objventaconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objventaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ventaconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor VENTACONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1idCliente = VENTACONVE2_A1idCliente[0];
            A37tipoFacturaVenta = VENTACONVE2_A37tipoFacturaVenta[0];
            A31porcentajeIVA = VENTACONVE2_A31porcentajeIVA[0];
            A30fechaVenta = VENTACONVE2_A30fechaVenta[0];
            A5idVenta = VENTACONVE2_A5idVenta[0];
            /*
               INSERT RECORD ON TABLE GXA0005

            */
            AV2idVenta = A5idVenta;
            AV3fechaVenta = A30fechaVenta;
            AV4porcentajeIVA = (long)(A31porcentajeIVA);
            AV5tipoFacturaVenta = A37tipoFacturaVenta;
            AV6idCliente = A1idCliente;
            /* Using cursor VENTACONVE3 */
            pr_default.execute(1, new Object[] {AV2idVenta, AV3fechaVenta, AV4porcentajeIVA, AV5tipoFacturaVenta, AV6idCliente});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0005") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         VENTACONVE2_A1idCliente = new short[1] ;
         VENTACONVE2_A37tipoFacturaVenta = new short[1] ;
         VENTACONVE2_A31porcentajeIVA = new decimal[1] ;
         VENTACONVE2_A30fechaVenta = new DateTime[] {DateTime.MinValue} ;
         VENTACONVE2_A5idVenta = new short[1] ;
         A30fechaVenta = DateTime.MinValue;
         AV3fechaVenta = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ventaconversion__default(),
            new Object[][] {
                new Object[] {
               VENTACONVE2_A1idCliente, VENTACONVE2_A37tipoFacturaVenta, VENTACONVE2_A31porcentajeIVA, VENTACONVE2_A30fechaVenta, VENTACONVE2_A5idVenta
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A1idCliente ;
      private short A37tipoFacturaVenta ;
      private short A5idVenta ;
      private short AV2idVenta ;
      private short AV5tipoFacturaVenta ;
      private short AV6idCliente ;
      private int GIGXA0005 ;
      private long AV4porcentajeIVA ;
      private decimal A31porcentajeIVA ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A30fechaVenta ;
      private DateTime AV3fechaVenta ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] VENTACONVE2_A1idCliente ;
      private short[] VENTACONVE2_A37tipoFacturaVenta ;
      private decimal[] VENTACONVE2_A31porcentajeIVA ;
      private DateTime[] VENTACONVE2_A30fechaVenta ;
      private short[] VENTACONVE2_A5idVenta ;
   }

   public class ventaconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmVENTACONVE2 ;
          prmVENTACONVE2 = new Object[] {
          } ;
          Object[] prmVENTACONVE3 ;
          prmVENTACONVE3 = new Object[] {
          new Object[] {"@AV2idVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3fechaVenta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV4porcentajeIVA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV5tipoFacturaVenta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6idCliente",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("VENTACONVE2", "SELECT [idCliente], [tipoFacturaVenta], [porcentajeIVA], [fechaVenta], [idVenta] FROM [Venta] ORDER BY [idVenta] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmVENTACONVE2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("VENTACONVE3", "INSERT INTO [GXA0005]([idVenta], [fechaVenta], [porcentajeIVA], [tipoFacturaVenta], [idCliente]) VALUES(@AV2idVenta, @AV3fechaVenta, @AV4porcentajeIVA, @AV5tipoFacturaVenta, @AV6idCliente)", GxErrorMask.GX_NOMASK,prmVENTACONVE3)
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
       }
    }

 }

}
