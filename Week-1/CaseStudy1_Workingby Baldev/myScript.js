//this code is for Parallax scrolling of background images

(function () {
 
  var myParallax = document.querySelectorAll(".bgImage"), speed = 0.3;
  
  window.onscroll = function () {
    
  myParallax.forEach(function (elP) {
    
    var windowYoffset = -window.pageYOffset, elPBackgroundPos = "50%" + (windowYoffset * speed)+"px";
    elP.style.backgroundPosition = elPBackgroundPos;
  });
  };
})();


//this code is for navigation bar on the top

$(window).scroll(function() {
  
  var wScroll = $(this).scrollTop();
  
  if (wScroll > $(".logoC").offset().top) {
    $(".navC").addClass("navShowing");
  }
  else if (wScroll < $(".logoC").offset().top) {
    $(".navC").removeClass("navShowing");
  }
  
  //To bring  the images one by one with animation
  
   if(wScroll > $(".productBox").offset().top
    - ($(window).height() / 1.5)) {
  
     $(".productBox").each(function(i) {
              
                          setTimeout(function() {
      $(".productBox").eq(i).addClass("isShowing");
        
    }, 150 * (i+1));
  });
}
  
  //End of one by one animation;
   });
      
//smooth transition when you click an element of NAV

$(function(){
  
  var section1C = $("#home").offset().top + 400;
  
  var section2C = $("#products").offset().top + 400;
    var section3C = $("#sales").offset().top + 400;
  var section4C = $("#about").offset().top +200;
  var section5C = $("#contact").offset().top;
  
  var activeLink;
  $(document).on("scroll", function(){
    var scrollUp = $(document).scrollTop();
    
    var activeLink;
    if(scrollUp <= section1C){
      
      activeLink = $(".menu-items >li:nth-child(1)");
    }
    else if (scrollUp < section2C){
       activeLink = $(".menu-items >li:nth-child(2)");
    }
    else if (scrollUp < section3C){
       activeLink = $(".menu-items >li:nth-child(3)");
    }
    else if (scrollUp < section4C){
       activeLink = $(".menu-items >li:nth-child(4)");
    }
    else if (scrollUp < section5C){
       activeLink = $(".menu-items >li:nth-child(5)");
    }
    
    activeLink.addClass("current");
    $(".menu-items>li").not(activeLink).removeClass("current");
  
  });
});


$(function(){
  var myNav = $(".navC").select();
  myNav.click(function(){
    alert($(".navC").scrollTop().top + "px");
  });
});

  

