$(function() {
	$(".rslides").responsiveSlides({
		speed: 100,
		timeout:120000,

	});
});

window.onload = function() {
	var _top = $('.sl-top-center').height();
	var _mtop = -(_top / 2);
	$('.sl-top-center').css('margin-top', _mtop);
};