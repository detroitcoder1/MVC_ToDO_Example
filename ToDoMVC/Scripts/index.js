﻿$(function () {
    
    checkHash();

    //this approach only supports IE8+, if IE 7 support was needed would need to pull in jQuery BBQ or similar
    $(window).on('hashchange', function () {
        checkHash();
    });
    
    function checkHash() {
        //some nasty hash string parsing to determine whether to show a detail panel. not extendable for a site getting bigger
        var token = "#";
        var hashIdx = window.location.hash.indexOf(token);
        var $detailContainer = $('#detail');

        if (hashIdx !== -1) {
            var detailUrl = '/' + window.location.hash.substring(hashIdx + token.length + 1);
            $detailContainer.load(detailUrl);
        } else {
            $detailContainer.html('');
        }
    }
});