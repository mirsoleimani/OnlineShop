if(typeof NetControls == "undefined") NetControls = new Object();
if(typeof NetControls.util == "undefined") NetControls.util = new Object();
if(typeof NetControls.NETswfUtil == "undefined") NetControls.NETswfUtil = new Object();

NetControls.NetSwf = function(swf, id, w, h, ver, skipDetect, useExpressInstall, xiRedirectUrl, redirectUrl){
	if (!document.createElement || !document.getElementById) { return; }
	this.params = new Object();
	this.variables = new Object();
	this.attributes = new Array();
	if(swf) {this.setAttribute('swf', swf);}
	if(id) {this.setAttribute('id', id);}
	if(w) {this.setAttribute('width', w);}
	if(h) {this.setAttribute('height', h);}
	this.skipDetect = skipDetect ? skipDetect : false;
	if(ver) {
		this.setAttribute('version', new NetControls.PlayerVersion(ver.toString().split(".")));
	}	
	this.installedVer = NetControls.NETswfUtil.getPlayerVersion(this.getAttribute('version'), useExpressInstall);
	this.setAttribute('useExpressInstall', useExpressInstall);
	this.setAttribute('doExpressInstall', false);
	var xir = (xiRedirectUrl) ? xiRedirectUrl : window.location;
	this.setAttribute('xiRedirectUrl', xir);
	this.setAttribute('redirectUrl', '');
	if(redirectUrl) {
		this.setAttribute('redirectUrl', redirectUrl);
	}	
}

NetControls.NetSwf.prototype = {
	setAttribute: function(name, value){
		this.attributes[name] = value;
	},
	getAttribute: function(name){
		return this.attributes[name];
	},
	addParam: function(name, value){
		this.params[name] = value;
	},
	getParams: function(){
		return this.params;
	},
	addVariable: function(name, value){
		this.variables[name] = value;
	},
	getVariable: function(name){
		return this.variables[name];
	},
	getVariables: function(){
		return this.variables;
	},
	createParamTag: function(n, v){
		var p = document.createElement('param');
		p.setAttribute('name', n);
		p.setAttribute('value', v);
		return p;
	},
	getVariablePairs: function(){
		var variablePairs = new Array();
		var key;
		var variables = this.getVariables();
		for(key in variables){
			variablePairs.push(key +"="+ variables[key]);
		}
		return variablePairs;
	},
	getFlashHTML: function() {
		var flashNode = "";
		//NETSCAPE
		if (navigator.plugins && navigator.mimeTypes && navigator.mimeTypes.length) {
			if (this.getAttribute("doExpressInstall")) this.addVariable("MMplayerType", "PlugIn");
			flashNode = '<embed type="application/x-shockwave-flash" src="'+ this.getAttribute('swf') +'" width="'+ this.getAttribute('width') +'" height="'+ this.getAttribute('height') +'"';
			flashNode += ' id="'+ this.getAttribute('id') +'" name="'+ this.getAttribute('id') +'" ';
			var params = this.getParams();
			for(var key in params){
				flashNode += [key] +'="'+ params[key] +'" ';
			}
			var pairs = this.getVariablePairs().join("&");
			if (pairs.length > 0){
				flashNode += 'flashvars="'+ pairs +'"';
			}
			flashNode += '/>';
		}
		//IE
		else{
			if (this.getAttribute("doExpressInstall")) this.addVariable("MMplayerType", "ActiveX");
			flashNode = '<object id="'+ this.getAttribute('id') +'" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="'+ this.getAttribute('width') +'" height="'+ this.getAttribute('height') +'">';
			flashNode += '<param name="movie" value="'+ this.getAttribute('swf') +'" />';
			var params = this.getParams();
			for(var key in params) {
				flashNode += '<param name="'+ key +'" value="'+ params[key] +'" />';
			}
			var pairs = this.getVariablePairs().join("&");
			if(pairs.length > 0) {
				flashNode += '<param name="flashvars" value="'+ pairs +'" />';
			}
			flashNode += "</object>";
		}
		return flashNode;
	},
	write: function(elementId){
		if(this.useExpressInstall) {
			// Express Install
			var expressInstallReqVer = new NetControls.PlayerVersion([6,0,65]);
			if (this.installedVer.versionIsValid(expressInstallReqVer) && !this.installedVer.versionIsValid(this.getAttribute('version'))) {
				this.setAttribute('doExpressInstall', true);
				this.addVariable("MMredirectURL", escape(this.getAttribute('xiRedirectUrl')));
				document.title = document.title.slice(0, 47) + " - Flash Player Installation";
				this.addVariable("MMdoctitle", document.title);
			}
		}
		else {
			this.setAttribute('doExpressInstall', false);
		}
		var ObjLocation = (typeof elementId == 'string') ? document.getElementById(elementId) : elementId;
		if(this.skipDetect || this.getAttribute('doExpressInstall') || this.installedVer.versionIsValid(this.getAttribute('version'))){
			ObjLocation.innerHTML = this.getFlashHTML();
		}
		else{
			if(this.getAttribute('redirectUrl') != "") {
				document.location.replace(this.getAttribute('redirectUrl'));
			}
			else{
				var place = document.location.toString();
				if (place.indexOf("http:\/\/localhost\/")!=-1){
					place = place.split("http://localhost/").join("");
				}
				else {
					place = place.split("http://").join("");
					place = place.split("https://").join("");
				}
				var j = 0;
				if (place.indexOf("\/")!=-1){
					place = place.split("\/");
					j = place.length-2;
				}
				place = "";
				for (i=0; i<j; i++){
					place += "../";
				}
				var txt = "<a href='http://www.macromedia.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash'>";
				txt += "Download Flash Player";
				txt += "</a>";
				ObjLocation.innerHTML = txt;
			}
		}
	}
}

/* ---- Player Version ---- */
NetControls.NETswfUtil.getPlayerVersion = function(reqVer, xiInstall){
	ver = reqVer.major + "." + reqVer.minor + "." + reqVer.rev;
	var PlayerVersion = new NetControls.PlayerVersion(ver.toString().split("."));
	if(navigator.plugins && navigator.mimeTypes.length){
		var x = navigator.plugins["Shockwave Flash"];
		if(x && x.description) {
			PlayerVersion = new NetControls.PlayerVersion(x.description.replace(/([a-z]|[A-Z]|\s)+/, "").replace(/(\s+r|\s+b[0-9]+)/, ".").split("."));
		}
	}
	else{
		try{
			var axo = new ActiveXObject("ShockwaveFlash.ShockwaveFlash");
			for (var i=3; axo!=null; i++) {
				axo = new ActiveXObject("ShockwaveFlash.ShockwaveFlash."+i);
				PlayerVersion = new NetControls.PlayerVersion([i,0,0]);
			}
		}
		catch(e){}
		if (reqVer && PlayerVersion.major > reqVer.major) return PlayerVersion; // version is ok, skip minor detection
		if (!reqVer || ((reqVer.minor != 0 || reqVer.rev != 0) && PlayerVersion.major == reqVer.major) || PlayerVersion.major != 6 || xiInstall) {
			try{
				PlayerVersion = new NetControls.PlayerVersion(axo.GetVariable("$version").split(" ")[1].split(","));
			}
			catch(e){}
		}
	}
	return PlayerVersion;
}

NetControls.PlayerVersion = function(arrVersion){
	this.major = parseInt(arrVersion[0]) || 0;
	this.minor = parseInt(arrVersion[1]) || 0;
	this.rev = parseInt(arrVersion[2]) || 0;
}

NetControls.PlayerVersion.prototype.versionIsValid = function(fv){
	if(this.major < fv.major) return false;
	if(this.major > fv.major) return true;
	if(this.minor < fv.minor) return false;
	if(this.minor > fv.minor) return true;
	if(this.rev < fv.rev) return false;
	return true;
}

if (Array.prototype.push == null) {
	Array.prototype.push = function(item) {
		this[this.length] = item;
		return this.length;
	}
}

var NetSwf = NetControls.NetSwf;

//BEGIN_AJAX_NOTIFY
if (typeof(Sys) != "undefined"){if (Sys.Application != null && Sys.Application.notifyScriptLoaded != null){Sys.Application.notifyScriptLoaded();}}
//END_AJAX_NOTIFY
