﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMedsoft.Data.Migrations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Sql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Sql() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TMedsoft.Data.Migrations.Sql", typeof(Sql).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF (EXISTS (SELECT * 
        ///				 FROM INFORMATION_SCHEMA.TABLES 
        ///				 WHERE TABLE_SCHEMA = &apos;dbo&apos; 
        ///				 AND  TABLE_NAME = &apos;doc_OrderBooks&apos;))
        ///
        ///				 Begin 
        ///				 IF (NOT EXISTS (SELECT count(b.ID) 
        ///				 FROM doc_OrderBooks b ))
        ///				 begin 
        ///				 
        ///INSERT INTO [dbo].[doc_OrderBooks] ([OrderID], [BookID], [Cost], [Quantity]) VALUES (59, 30, CAST(3855.47 AS Decimal(18, 2)), 3)
        ///INSERT INTO [dbo].[doc_OrderBooks] ([OrderID], [BookID], [Cost], [Quantity]) VALUES (66, 33, CAST(2020.81 AS Decimal(18, 2)), 7)
        ///INSERT [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbo_doc_OrderBooks_data {
            get {
                return ResourceManager.GetString("dbo_doc_OrderBooks_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF (EXISTS (SELECT * 
        ///                 FROM INFORMATION_SCHEMA.TABLES 
        ///                 WHERE TABLE_SCHEMA = &apos;dbo&apos; 
        ///                 AND  TABLE_NAME = &apos;doc_Orders&apos;))
        ///
        ///				 Begin 
        ///				 IF (NOT EXISTS (SELECT count(b.ID) 
        ///                 FROM doc_Orders b ))
        ///				 begin 
        ///SET IDENTITY_INSERT [dbo].[doc_Orders] ON
        ///INSERT INTO [dbo].[doc_Orders] ([ID], [Name], [Quantity], [Cost], [DiscountID]) VALUES (1, N&apos;Nicole2&apos;, 294, CAST(2571.15 AS Decimal(18, 2)), 1)
        ///INSERT INTO [dbo].[doc_Orders] ([ID], [Name], [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbo_doc_Orders_data {
            get {
                return ResourceManager.GetString("dbo_doc_Orders_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///IF (EXISTS (SELECT * 
        ///                 FROM INFORMATION_SCHEMA.TABLES 
        ///                 WHERE TABLE_SCHEMA = &apos;dbo&apos; 
        ///                 AND  TABLE_NAME = &apos;ref_Books&apos;))
        ///
        ///				 Begin 
        ///				 IF (NOT EXISTS (SELECT count(b.ID) 
        ///                 FROM ref_Books b ))
        ///				 begin 
        ///				 
        ///SET IDENTITY_INSERT [dbo].[ref_Books] ON
        ///INSERT INTO [dbo].[ref_Books] ([ID], [Name], [GenreID], [Quantity], [Cost]) VALUES (1, N&apos;Ginger993&apos;, 8, 118, CAST(297.20 AS Decimal(18, 2)))
        ///INSERT INTO [dbo].[ref_Books] ([ID], [Name [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbo_ref_Books_data {
            get {
                return ResourceManager.GetString("dbo_ref_Books_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF (EXISTS (SELECT * 
        ///				 FROM INFORMATION_SCHEMA.TABLES 
        ///				 WHERE TABLE_SCHEMA = &apos;dbo&apos; 
        ///				 AND  TABLE_NAME = &apos;ref_DiscountBooks&apos;))
        ///
        ///				 Begin 
        ///				 IF (NOT EXISTS (SELECT count(b.ID) 
        ///				 FROM ref_DiscountBooks b ))
        ///				 begin 
        ///				 
        ///INSERT INTO [dbo].[ref_DiscountBooks] ([DiscountID], [BookID]) VALUES (3, 1)
        ///INSERT INTO [dbo].[ref_DiscountBooks] ([DiscountID], [BookID]) VALUES (1, 2)
        ///		 
        ///				 end
        ///				 END.
        /// </summary>
        public static string dbo_ref_DiscountBooks_data {
            get {
                return ResourceManager.GetString("dbo_ref_DiscountBooks_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [dbo].[ref_DiscountGenres] ([DiscountID], [GenreID]) VALUES (3, 8)
        ///INSERT INTO [dbo].[ref_DiscountGenres] ([DiscountID], [GenreID]) VALUES (1, 9)
        ///.
        /// </summary>
        public static string dbo_ref_DiscountGenres_data {
            get {
                return ResourceManager.GetString("dbo_ref_DiscountGenres_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET IDENTITY_INSERT [dbo].[ref_DiscountRules] ON
        ///INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (1, N&apos;Jeanine25&apos;, 6, 3)
        ///INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (2, N&apos;Valerie&apos;, 7, 1)
        ///INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (3, N&apos;Roy5&apos;, 10, 1)
        ///INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (4, N&apos;Ron506&apos;, 8, 3)
        ///SET IDENTIT [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbo_ref_DiscountRules_data {
            get {
                return ResourceManager.GetString("dbo_ref_DiscountRules_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET IDENTITY_INSERT [dbo].[ref_Discounts] ON
        ///INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode]) VALUES (1, N&apos;Joyce&apos;, CAST(55.67 AS Decimal(18, 2)), N&apos;S43L6E&apos;)
        ///INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode]) VALUES (2, N&apos;Rick562&apos;, CAST(17.64 AS Decimal(18, 2)), N&apos;B3741NHZ3Y5EOC6IC8HOOFDOZ9II2UTZ0PPKVTBS6SD53YPPMANOZB81N3XCFRGOJBFM&apos;)
        ///INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode]) VALUES (3, N&apos;Ted259&apos;, CAST(75.08 AS Decimal [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbo_ref_Discounts_data {
            get {
                return ResourceManager.GetString("dbo_ref_Discounts_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET IDENTITY_INSERT [dbo].[ref_Genres] ON
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VALUES (1, N&apos;Maggie87&apos;)
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VALUES (2, N&apos;Roger0&apos;)
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VALUES (3, N&apos;Rochelle&apos;)
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VALUES (4, N&apos;Donald&apos;)
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VALUES (5, N&apos;Alana&apos;)
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VALUES (6, N&apos;Dianna247&apos;)
        ///INSERT INTO [dbo].[ref_Genres] ([ID], [Name]) VAL [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbo_ref_Genres_data {
            get {
                return ResourceManager.GetString("dbo_ref_Genres_data", resourceCulture);
            }
        }
    }
}
