define(['jquery', 'require', 'umbiliko', 'umbiliko.ajax', 'umbiliko.auth', 'umbiliko.message', 'umbiliko.contact.widget', 'umbiliko.enter.widget', 'umbiliko.logo.widget'], function ($, require, U) {
    'use strict'

    $(document).ready(function () {
        var $enter = $('.home-header .umbiliko-enter-placeholder'),
            $brand = $('.brand'),
            canvas = $('<canvas></canvas>').appendTo($enter).get(0),
            _contact,
            _enter;

        canvas.height = $enter.width();
        canvas.width = $enter.height();

        if ($.browser.webkit) {
            var loader = U.logo(canvas, 40);
            loader.opacity(.5);
            loader.spin();
        }

        setTimeout(function () {
            _enter = U.enter($enter);
            if ($.browser.webkit) {
                _enter.blend();
            }
            _enter.ready(function () {
                if ($.browser.webkit) {
                    loader.stop();
                }
                //loader = null;
                //$brand.removeClass('hidden');
            }).done(function ($el) {
                $el.replaceWith($enter);
                if ($.browser.webkit) {
                    loader.spin();
                }
            });
        }, 10);
    });
});