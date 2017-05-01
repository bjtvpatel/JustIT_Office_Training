/*This is the jQuery code for the carousel*/

//my variables

var dAnswerId;

var dQuestionsId;

var answersInArray;

var allAnswers;

var myAnswersArray = [];

//var dValueId;


//my Event listenners

var startAgain = document.getElementById("checkR");

startAgain.addEventListener("click", resetAll, false);

function resetAll() {
  
    for(var i = 0; i < myAnswersArray.length; i++) {
    
    answersInArray = myAnswersArray[i];
    
    allAnswers= document.getElementById(answersInArray);
    
    allAnswers.className = "theAnswer";
  
    allAnswers.style.display = "block";
    
    var allAnswersIds = document.getElementById("r" + answersInArray);
    
    allAnswersIds.appendChild(allAnswers);
            
  }
  
}

//the first drag and drop attribute

function dragStart(ev)
{
  
  ev.dataTransfer.setData("text", ev.target.id);
  
  dAnswerId = ev.target.getAttribute("id");
  
  dValueId = "a" + ev.target.getAttribute("value");
    
}

function dragOver(ev) {
  
  ev.preventDefault();
}


// the magic happerns here

function dragDrop(ev){
  
  ev.preventDefault();
  
  if(!ev.target.getAttribute("ondrop")){
    
    return false;
    
  }
  
  var Data = ev.dataTransfer.getData("text");
  
  ev.target.appendChild(document.getElementById(data));
  
  dQuestionsId = ev.target.getAttribute("id");
  
  if(dQuestionsId === dValueId) {
    
    document.getElementById(dAnswerId).className = "correct";
          
  } else if (dQuestionsId !== dValueId)
    {
      document.getElementById(dAnswerId).className = "theAnswers";
                
    }
  
  // to collect answers and push it to the array
  
  myAnswersArray.push(dAnswerId);

  
}



//This is the carousel jQuery code

$(document).ready( function() {
    $('#myCarousel').carousel({
    	interval: 0
	});
	
	var clickEvent = false;
	$('#myCarousel').on('click', '.nav a', function() {
			clickEvent = true;
			$('.nav li').removeClass('active');
			$(this).parent().addClass('active');		
	}).on('slid.bs.carousel', function(e) {
		if(!clickEvent) {
			var count = $('.nav').children().length -1;
			var current = $('.nav li.active');
			current.removeClass('active').next().addClass('active');
			var id = parseInt(current.data('slide-to'));
			if(count == id) {
				$('.nav li').first().addClass('active');	
			}
		}
		clickEvent = false;
	});
});




//Hide email address JS with some DOM manipulation

var myEmail = document.createElement("span");

myEmail.innerHTML = "";

document.getElementById("hideEmail").appendChild(myEmail);
document.getElementById("hideEmail").setAttribute("href","mailto:manuelc@justit.co.uk");









