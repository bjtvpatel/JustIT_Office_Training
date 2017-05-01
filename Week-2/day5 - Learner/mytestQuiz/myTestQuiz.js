function hideQuestionEle(){
  
  
  var quesPanel = document.getElementById("actualQuiz")
  
  console.log(quesPanel);
  
//  for(var i =0; i<quesPanel.length; i++){
      quesPanel.style.display = "none";
//    }
}


function loadQuestionpage(){
  
  document.getElementById("actualQuiz").style.display="inline";
  
  document.getElementById("qAll_questions").className = "hide";
    document.getElementById("submit_answer").className = "submit_answer btn btn-primary";
    
    document.getElementById("actual_quiz_all").className = "quiz_display show_it";
  
}

function restartTest(){
   
  location.reload();
  
  
  
}

window.addEventListener("load",hideQuestionEle,false);

document.getElementById("mathBtn").addEventListener("click", loadQuestionpage,false);

document.getElementById("reset").addEventListener("click", restartTest, false);







