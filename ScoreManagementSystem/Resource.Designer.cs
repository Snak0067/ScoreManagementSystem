﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoreManagementSystem {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ScoreManagementSystem.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 /*
        ///Document: app.js
        ///Author: Rustheme
        ///Description: UI Framework Custom Functionality (available to all pages)
        ///*/
        ///
        ///var App = function() {
        ///
        ///	/**
        ///	 * CORE UI FUNCTIONALITY
        ///	 * Functions which handle core UI functionality such as Bootstrap plugins and navigation
        ///	 * They are auto initialized on every page
        ///	 */
        ///
        ///
        ///	// Color variables
        ///	var colors = {
        ///		primary: &apos;#7dc855&apos;,
        ///		green: &apos;#7dc855&apos;,
        ///		blue: &apos;#358ed7&apos;,
        ///		cyan: &apos;#39add1&apos;,
        ///		purple: &apos;#838cc7&apos;,
        ///		orange: &apos;#f8e71b&apos;,
        ///		red: &apos;#ef3000&apos;,
        ///		t [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string app {
            get {
                return ResourceManager.GetString("app", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: app-custom.js
        ///Author: Rustheme
        ///Description: Write your custom code here
        ///*/
        ///
        ///// Below is an example of function and its initialization
        ///var AppCustom = function() {
        ///	var showAppName = function() {
        ///		console.log( &apos;AppUI - Admin &amp; Frontend template&apos; );
        ///	};
        ///
        ///	return {
        ///		init: function() {
        ///			showAppName();
        ///		}
        ///	}
        ///}();
        ///
        ///// Initialize AppCustom when page loads
        ///jQuery( function() {
        ///	AppCustom.init();
        ///});
        /// 的本地化字符串。
        /// </summary>
        public static string app_custom {
            get {
                return ResourceManager.GetString("app_custom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap background1 {
            get {
                object obj = ResourceManager.GetObject("background1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_forms_validation.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Form Validation Page
        /// */
        ///
        ///var BaseFormValidation = function() {
        ///    // Init Bootstrap Forms Validation: https://github.com/jzaefferer/jquery-validation
        ///    var initValidationBootstrap = function() {
        ///        jQuery( &apos;.js-validation-bootstrap&apos; ).validate({
        ///            errorClass: &apos;help-block animated fadeInDown&apos;,
        ///            errorElement: &apos;div&apos;,
        ///            errorPlacement: function( error, e ) {
        ///                jQuery(e [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_forms_validation {
            get {
                return ResourceManager.GetString("base_forms_validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_forms_wizard.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Form Wizard Page
        /// */
        ///
        ///var BaseFormWizard = function() {
        ///	// Init simple wizard: http://vadimg.com/twitter-bootstrap-wizard-example/
        ///	var initWizardSimple = function() {
        ///		jQuery( &apos;.js-wizard-simple&apos; ).bootstrapWizard({
        ///			&apos;tabClass&apos;: &apos;&apos;,
        ///			&apos;firstSelector&apos;: &apos;.wizard-first&apos;,
        ///			&apos;previousSelector&apos;: &apos;.wizard-prev&apos;,
        ///			&apos;nextSelector&apos;: &apos;.wizard-next&apos;,
        ///			&apos;lastSelector&apos;: &apos;.wizard-last&apos;,
        ///			&apos;onTabShow&apos;: function( $tab, $navigati [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_forms_wizard {
            get {
                return ResourceManager.GetString("base_forms_wizard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_js_charts_chartjs.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Charts Chart.js Page
        ///*/
        ///
        ///var BaseJsCharts = function() {
        ///	// Chart.js Charts: http://www.chartjs.org/docs
        ///	var initChartsChartJS = function() {
        ///
        ///		// Get Chart Containers
        ///		var $chartLinesCnt = jQuery( &apos;.js-chartjs-lines&apos; )[0].getContext( &apos;2d&apos; ),
        ///			$chartBarsCnt = jQuery( &apos;.js-chartjs-bars&apos; )[0].getContext( &apos;2d&apos; ),
        ///			$chartRadarCnt = jQuery( &apos;.js-chartjs-radar&apos; )[0].getContext( &apos;2d&apos; ),
        ///			$chartPolarCnt = jQuery( &apos; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_js_charts_chartjs {
            get {
                return ResourceManager.GetString("base_js_charts_chartjs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_js_charts_flot.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Charts Flot Page
        ///*/
        ///
        ///var BaseJsCharts = function() {
        ///
        ///	// Flot charts: http://www.flotcharts.org/flot/examples/
        ///	var initChartsFlot = function() {
        ///		// Get the elements where we will attach the charts
        ///		var $flotLines = jQuery( &apos;.js-flot-lines&apos; );
        ///		var $flotStacked = jQuery( &apos;.js-flot-stacked&apos; );
        ///		var $flotLive = jQuery( &apos;.js-flot-live&apos; );
        ///		var $flotPie = jQuery( &apos;.js-flot-pie&apos; );
        ///		var $flotBars = jQuery( &apos;.js-flot- [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_js_charts_flot {
            get {
                return ResourceManager.GetString("base_js_charts_flot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_js_charts_sparkline.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Charts Sparkline Page
        ///*/
        ///
        ///var BaseJsCharts = function() {
        ///	// jQuery Sparkline Charts: http://omnipotent.net/jquery.sparkline/#s-docs
        ///	var initChartsSparkline = function() {
        ///		// Bar Charts
        ///		var $barOptions = {
        ///			type: &apos;bar&apos;,
        ///			barWidth: 8,
        ///			barSpacing: 6,
        ///			height: &apos;70px&apos;,
        ///			barColor: App.colors.green,
        ///			tooltipPrefix: &apos;&apos;,
        ///			tooltipSuffix: &apos; Revenue&apos;,
        ///			tooltipFormat: &apos;{{prefix}}{{value}}{{suffix}}&apos;
        ///		}; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_js_charts_sparkline {
            get {
                return ResourceManager.GetString("base_js_charts_sparkline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_js_maps.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Maps Page
        /// */
        ///
        ///var BaseJsMaps = function() {
        ///	// Init Map with Search
        ///	var initMapSearch = function() {
        ///		// Init Map
        ///		var $mapSearch = new GMaps({
        ///			div: &apos;#js-map-search&apos;,
        ///			lat: 20,
        ///			lng: 0,
        ///			zoom: 2,
        ///			scrollwheel: false
        ///		});
        ///
        ///		// When the search form is submitted
        ///		jQuery( &apos;.js-form-search&apos; ).on( &apos;submit&apos;, function() {
        ///			GMaps.geocode({
        ///				address: jQuery( &apos;.js-search-address&apos; ).val().trim(),
        ///				callback: func [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_js_maps {
            get {
                return ResourceManager.GetString("base_js_maps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_tables_datatables.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Tables Datatables Page
        /// */
        ///
        ///var BaseTableDatatables = function() {
        ///	// Init full DataTable: https://www.datatables.net/
        ///	var initDataTableFull = function() {
        ///		jQuery( &apos;.js-dataTable-full&apos; ).dataTable({
        ///			columnDefs: [ { orderable: false, targets: [ 4 ] } ],
        ///			pageLength: 10,
        ///			lengthMenu: [[5, 10, 15, 20], [5, 10, 15, 20]]
        ///		});
        ///	};
        ///
        ///	// Init simple DataTable: https://www.datatables.net/
        ///	var initDataTableSimple  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_tables_datatables {
            get {
                return ResourceManager.GetString("base_tables_datatables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_ui_progress.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Progress Page
        /// */
        ///
        ///var BaseUIProgress = function() {
        ///    // Randomize progress bars values
        ///    var barsRandomize = function() {
        ///        jQuery( &apos;.js-bar-randomize&apos; ).on( &apos;click&apos;, function() {
        ///            jQuery( this )
        ///                .parents( &apos;.card&apos; )
        ///                .find( &apos;.progress-bar&apos; )
        ///                .each( function() {
        ///                    var $this   = jQuery( this );
        ///                    var $random = Math.floor [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string base_ui_progress {
            get {
                return ResourceManager.GetString("base_ui_progress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap bg1 {
            get {
                object obj = ResourceManager.GetObject("bg1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap bg2 {
            get {
                object obj = ResourceManager.GetObject("bg2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 /*!
        /// * Bootstrap v3.3.6 (http://getbootstrap.com)
        /// * Copyright 2011-2015 Twitter, Inc.
        /// * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
        /// */
        ///if(&quot;undefined&quot;==typeof jQuery)throw new Error(&quot;Bootstrap&apos;s JavaScript requires jQuery&quot;);+function(a){&quot;use strict&quot;;var b=a.fn.jquery.split(&quot; &quot;)[0].split(&quot;.&quot;);if(b[0]&lt;2&amp;&amp;b[1]&lt;9||1==b[0]&amp;&amp;9==b[1]&amp;&amp;b[2]&lt;1)throw new Error(&quot;Bootstrap&apos;s JavaScript requires jQuery version 1.9.1 or higher&quot;)}(jQuery),+function(a){&quot;use strict&quot;;function b(){var a=docume [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string bootstrap_min {
            get {
                return ResourceManager.GetString("bootstrap_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /* iCheck plugin Square skin, green
        ///----------------------------------- */
        ///.icheckbox_square-green,
        ///.iradio_square-green {
        ///    display: inline-block;
        ///    *display: inline;
        ///    vertical-align: middle;
        ///    margin: 0;
        ///    padding: 0;
        ///    height: 14px;
        ///    width: 14px;
        ///    background: url(green1.png) no-repeat;
        ///    border: none;
        ///    cursor: pointer;
        ///    background-size:cover;
        ///    background-position: center;
        ///    text-align:center;
        ///    border: 1px solid #666666;
        ///}
        ///
        ///.icheckbox_square-green {
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string custom {
            get {
                return ResourceManager.GetString("custom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap dlsm {
            get {
                object obj = ResourceManager.GetObject("dlsm", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap ewm {
            get {
                object obj = ResourceManager.GetObject("ewm", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: frontend_contact.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Frontend Contact Page
        /// */
        ///
        ///var FrontendContact = function() {
        ///	// Init Contact Map with Gmaps.js: https://hpneo.github.io/gmaps/
        ///	var initContactMap = function() {
        ///		new GMaps({
        ///			div: &apos;#js-map-contact&apos;,
        ///			lat: 37.75755,
        ///			lng: -122.43688,
        ///			zoom: 15,
        ///			disableDefaultUI: true,
        ///			scrollwheel: false
        ///		}).addMarkers([{
        ///			lat: 37.75755,
        ///			lng: -122.43688,
        ///			title: &apos;AppUI Office&apos;,
        ///			animation: google.maps.Animation.DR [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string frontend_contact {
            get {
                return ResourceManager.GetString("frontend_contact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap head1 {
            get {
                object obj = ResourceManager.GetObject("head1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap head2 {
            get {
                object obj = ResourceManager.GetObject("head2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap head3 {
            get {
                object obj = ResourceManager.GetObject("head3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap head4 {
            get {
                object obj = ResourceManager.GetObject("head4", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap headPortrait {
            get {
                object obj = ResourceManager.GetObject("headPortrait", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap iconi {
            get {
                object obj = ResourceManager.GetObject("iconi", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///Document: base_pages_dashboard.js
        ///Author: Rustheme
        ///Description: Custom JS code used in Dashboard Page (index.html)
        /// */
        ///
        ///var BasePagesDashboard = function() {
        ///	// Chart.js Chart: http://www.chartjs.org/docs
        ///	var initDashChartJS = function() {
        ///
        ///		// Get Chart Containers
        ///		var $dashChartLinesCnt1 = jQuery( &apos;.js-chartjs-lines1&apos; )[0].getContext( &apos;2d&apos; ),
        ///			$dashChartLinesCnt2 = jQuery( &apos;.js-chartjs-lines2&apos; )[0].getContext( &apos;2d&apos; ),
        ///			$dashChartBarsCnt = jQuery( &apos;.js-chartjs-bars&apos; )[0].getContext( &apos;2d&apos; ),
        ///			$ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string index {
            get {
                return ResourceManager.GetString("index", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*! jQuery v2.1.4 | (c) 2005, 2015 jQuery Foundation, Inc. | jquery.org/license */
        ///!function(a,b){&quot;object&quot;==typeof module&amp;&amp;&quot;object&quot;==typeof module.exports?module.exports=a.document?b(a,!0):function(a){if(!a.document)throw new Error(&quot;jQuery requires a window with a document&quot;);return b(a)}:b(a)}(&quot;undefined&quot;!=typeof window?window:this,function(a,b){var c=[],d=c.slice,e=c.concat,f=c.push,g=c.indexOf,h={},i=h.toString,j=h.hasOwnProperty,k={},l=a.document,m=&quot;2.1.4&quot;,n=function(a,b){return new n.fn.init(a,b)},o=/^[ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string jquery_min {
            get {
                return ResourceManager.GetString("jquery_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /* HTML5 Placeholder jQuery Plugin - v2.1.1
        /// * Copyright (c)2015 Mathias Bynens
        /// * 2015-02-19
        /// */
        ///!function(a){&quot;function&quot;==typeof define&amp;&amp;define.amd?define([&quot;jquery&quot;],a):a(jQuery)}(function(a){function b(b){var c={},d=/^jQuery\d+$/;return a.each(b.attributes,function(a,b){b.specified&amp;&amp;!d.test(b.name)&amp;&amp;(c[b.name]=b.value)}),c}function c(b,c){var d=this,f=a(d);if(d.value==f.attr(&quot;placeholder&quot;)&amp;&amp;f.hasClass(m.customClass))if(f.data(&quot;placeholder-password&quot;)){if(f=f.hide().nextAll(&apos;input[type=&quot;password&quot;]:first&apos;).s [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string jquery_placeholder_min {
            get {
                return ResourceManager.GetString("jquery_placeholder_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*!
        /// * Scroll Lock v1.1.1
        /// * https://github.com/MohammadYounes/jquery-scrollLock
        /// *
        /// * Copyright (c) 2014 Mohammad Younes
        /// * Licensed under the MIT license.
        /// */
        ///(function(n){typeof define===&quot;function&quot;&amp;&amp;define.amd?define([&quot;jquery&quot;],n):n(jQuery)})(function(n){function u(n){var t=n.prop(&quot;clientWidth&quot;),i=n.prop(&quot;offsetWidth&quot;),r=parseInt(n.css(&quot;border-right-width&quot;),10),u=parseInt(n.css(&quot;border-left-width&quot;),10);return t+u+r&lt;i}var i=&quot;onmousewheel&quot;in window?&quot;ActiveXObject&quot;in window?&quot;wheel&quot;:&quot;mousewheel&quot;:&quot;DOMMouseScr [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string jquery_scrollLock_min {
            get {
                return ResourceManager.GetString("jquery_scrollLock_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*! Copyright (c) 2011 Piotr Rochala (http://rocha.la)
        /// * Dual licensed under the MIT (http://www.opensource.org/licenses/mit-license.php)
        /// * and GPL (http://www.opensource.org/licenses/gpl-license.php) licenses.
        /// *
        /// * Version: 1.3.3
        /// *
        /// */
        ///(function(e){e.fn.extend({slimScroll:function(g){var a=e.extend({width:&quot;auto&quot;,height:&quot;250px&quot;,size:&quot;7px&quot;,color:&quot;#000&quot;,position:&quot;right&quot;,distance:&quot;1px&quot;,start:&quot;top&quot;,opacity:.4,alwaysVisible:!1,disableFadeOut:!1,railVisible:!1,railColor:&quot;#333&quot;,railOpacity:.2,railDraggable:!0, [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string jquery_slimscroll_min {
            get {
                return ResourceManager.GetString("jquery_slimscroll_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 .auth_bg {
        ///    position: fixed;
        ///    top: -50%;
        ///    left: -50%;
        ///    width: 200%;
        ///    height: 200%;
        ///    z-index: -1;
        ///}
        ///
        ///.auth_bg img {
        ///    position: absolute;
        ///    top: 0;
        ///    left: 0;
        ///    right: 0;
        ///    bottom: 0;
        ///    margin: auto;
        ///    min-width: 50%;
        ///    min-height: 50%;
        ///}
        ///
        ///body {
        ///    margin: 0;
        ///}
        ///
        ///.xiaoxun {
        ///    position: absolute;
        ///    bottom: 0;
        ///    right: 120px;
        ///    width: 220px !important;
        ///}
        ///
        ///.auth_page_wrapper {
        ///    width: 960px;
        ///    margin: 20px auto;
        ///    padding: 0;
        ///  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string login {
            get {
                return ResourceManager.GetString("login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap logo1 {
            get {
                object obj = ResourceManager.GetObject("logo1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap logo2 {
            get {
                object obj = ResourceManager.GetObject("logo2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap logo3 {
            get {
                object obj = ResourceManager.GetObject("logo3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap logo31 {
            get {
                object obj = ResourceManager.GetObject("logo31", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 .qr_scan_box {
        ///    margin: 0;
        ///    background: rgba(255,255,255,0.6);
        ///}
        ///.login--scan_box--scan {
        ///    display:table;
        ///    overflow:hidden;
        ///    position: absolute;
        ///    width:100%;
        ///    height:100%;
        ///    left: 0;
        ///    top: 0;
        ///    width: 100%;
        ///    height: 100%;
        ///}
        ///
        ///.login--scan_box--scan &gt;.login--scan_pic {
        ///    vertical-align:middle;
        ///    display:table-cell;
        ///    text-align:center;
        ///    top:50%;
        ///    left:50%;
        ///
        ///}
        ///
        ///.refresh--scan_Invalid {
        ///    position: absolute;
        ///    z-index: 10;
        ///    background [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string qrcode_basic {
            get {
                return ResourceManager.GetString("qrcode_basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap selfInfoBg {
            get {
                object obj = ResourceManager.GetObject("selfInfoBg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Success {
            get {
                object obj = ResourceManager.GetObject("Success", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap top {
            get {
                object obj = ResourceManager.GetObject("top", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap weixin {
            get {
                object obj = ResourceManager.GetObject("weixin", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zh {
            get {
                object obj = ResourceManager.GetObject("zh", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut1 {
            get {
                object obj = ResourceManager.GetObject("zjut1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut1_1 {
            get {
                object obj = ResourceManager.GetObject("zjut1_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut2 {
            get {
                object obj = ResourceManager.GetObject("zjut2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut2_1 {
            get {
                object obj = ResourceManager.GetObject("zjut2_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut3 {
            get {
                object obj = ResourceManager.GetObject("zjut3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut3_1 {
            get {
                object obj = ResourceManager.GetObject("zjut3_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut4 {
            get {
                object obj = ResourceManager.GetObject("zjut4", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut4_1 {
            get {
                object obj = ResourceManager.GetObject("zjut4_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut5 {
            get {
                object obj = ResourceManager.GetObject("zjut5", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut5_1 {
            get {
                object obj = ResourceManager.GetObject("zjut5_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut6 {
            get {
                object obj = ResourceManager.GetObject("zjut6", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap zjut6_1 {
            get {
                object obj = ResourceManager.GetObject("zjut6_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
