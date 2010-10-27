﻿var currentLoader;

function ViewerLoader(url, flashLoc, o3dLoc, axis, scale) {
    this.viewerLoaded = false;
    this.upAxis = axis;
    this.unitScale = scale;
    this.flashContentUrl = "";
    var path = window.location.href;
    var basePath = window.location.protocol + "//" + window.location.host + "/Public/";
    var index = path.lastIndexOf('/');
    o3dfilename = path.substring(path.lastIndexOf('='), path.length);
    var params = (axis != '' && scale != '') ? "&UpAxis=" + axis + "&UnitScale=" + scale : "";
    this.flashContentUrl = basePath + "Away3D/ViewerApplication_back.html?URL=" + basePath + url.replace("&", "_Amp_") + flashLoc + params;
    this.o3dContentUrl = url + o3dLoc;
    this.viewerMode = "o3d";
    
    this.pluginNotificationHtml = "<a id='HideButton' style='float: right; font-size: small; margin-right: 10px' href='#'>Hide</a><br />" +
                                  "You are using the Flash version of the 3D Viewer, which may cause performance issues when viewing large models. This page is optimized for the O3D Plugin." +
                                  "<br /><br />" + 
                                  "<span style='text-align: center;'>" + 
                                  "<a href='http://tools.google.com/dlpage/o3d' target='_blank'>Click here</a> to download O3D.</a>" +
                                  "</span>";

    this.viewerStatusElement = "#ViewerStatus";

    this.ShowNotificationMessage = vShowNotification;
    this.HideNotificationMessage = vHideNotification;
    o3dFailCallback.Sender = this;
    this.o3dFailureCallback = o3dFailCallback;
    
    this.LoadViewer = vLoad;
    this.ResetViewer = vReset;
    this.DestroyViewer = uninit;

    

    currentLoader = this;
   
}

function vLoad() {
    with (this) {
        if (!viewerLoaded) {
            //Try to load the o3d viewer
            if (viewerMode == 'o3d') {
                $('#plugin_Wrapper').show();
                init(o3dContentUrl, "", upAxis, unitScale, o3dFailureCallback);
            } else {
                $('#away3d_Wrapper').show();
                $('#flashFrame').attr("src", flashContentUrl);
            }
            viewerLoaded = true;
            $('body').attr('onunload', 'uninit();');
        }
    }
}

function vReset() {
    with (this) {
        reset();
        $('#o3d').html('');
        viewerLoaded = false;
    }
}

function vShowNotification() {
    with (this) {
        $(viewerStatusElement).html(this.pluginNotificationHtml);
        $('#HideButton').live('click', vHideNotification);
        $(viewerStatusElement).fadeIn(500);
    }
}

function vHideNotification() {
        $(currentLoader.viewerStatusElement).fadeOut(500);
        return false;
}

function o3dFailCallback(status, error, id, tag) {
        
        $('#plugin_Wrapper').hide();
        uninit();
        currentLoader.viewerLoaded = false;

        currentLoader.ShowNotificationMessage();
        currentLoader.viewerMode = "away3d";
        currentLoader.LoadViewer();
    }


    
