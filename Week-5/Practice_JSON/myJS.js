var obj = $.noConflict();
obj(document).ready(function(){
    
    var div = document.createElement('DIV');
    div.style.height='200vh';
    document.body.appendChild(div);
    
    div.addEventListener('mousemove', function(Event){
       console.log(Event) 
       var x = Event.clientX;
        var y= Event.clientY;
        div.textContent=x+' -- '+y;
        div.style.backgroundColor='rgb('+x+', '+y+', 100)';
       
    });
//            
//                    $.get( "myJSON.js", function( data ) {
//         console.log("success"); 
//                        $( ".result" ).html( data );
//   
//                        alert( "Load was performed." );
//
//                    });
    
    var ourRequest = new XMLHttpRequest();
    ourRequest.open('GET', "https://github.com/boennemann/animals/blob/master/words.json", JSON);
    ourRequest.onload = function(data){
        console.log(JSONP.parse(ourRequest.responseText));
        console.log(data); 
    };
    ourRequest.send();
    
    
    
//            
//           console.log("success"); 
//          
//            $("#message").addClass("mydiv");
//            
//            $("#message").add("p:first child").append("Hello World").addClass("myp");
//                
//            $('body').add("h1").append("LINQ");
//            
//            $("#name").css("background-color", "red");
//
//
//$("input").focusin(function(){
//             console.log("success"); 
//           
//            var name1 = $("h1").val();
//            
//            $("h1").text("SQL");
//});
//        
//$( "p" ).focusin(function() {
//    console.log("success"); 
//            $( this ).find( "span" ).css( "display", "inline" ).fadeOut(1000);
//});
//        
//               
//$("#btn1").click(function(){
//    console.log("success"); 
//            $("#test1").text(function(i, origText){
//                return "Old text: " + origText + " New text: Hello world! (index: " + i + ")"; 
//            });
//        });
//        
//
//        $( ":input" ).select(function() {
//            console.log("success"); 
//            $( "div" ).text( "Something was selected" ).show().fadeOut( 1000 );
//        });
//    
    
});

