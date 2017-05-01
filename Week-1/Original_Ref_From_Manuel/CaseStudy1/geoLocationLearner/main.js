//ADD EVENT LISTENERS
document.getElementById("mainAddress").addEventListener("click", firstMap, false);
document.getElementById("otherAddress").addEventListener("click", secondMap, false);
document.getElementById("officeAddresses").addEventListener("click", textAddress, false);

//Global var declaration
var map;

    
    //Code for the first map
    function firstMap() {
    
        // Creating a new variable to hold my lat and lng
          var officeLocation = {lat: 51.51234617, lng: -0.0752784};
    
        // Create a map object and specify the DOM element for display.
          map = new google.maps.Map(document.getElementById("displayAddress"), {
          center: officeLocation,
          scrollwheel : false,
          zoom: 16
        });
          var marker = new google.maps.Marker({
          position: officeLocation,
          map: map,
          title: 'Find us here!'
        });
    
          var popupAddress = "Just IT Training, 2nd Floor<br />";
              popupAddress += "St. Clare House<br />";
              popupAddress += "30-33 Minories<br />";
              popupAddress += "London EC3N 1DD<br />";
          
              
          var infowindow = new google.maps.InfoWindow({
          content: popupAddress,
          maxWidth: 300
        });
          marker.addListener('click', function() {
          infowindow.open(map, marker);
        });

      } 

    //Code for the second map
    function secondMap() {
        
    // Creating a new variable to hold my lat and lng
          var officeLocation = {lat: 51.5164788, lng: -0.0663546};
        
        // Create a map object and specify the DOM element for display.
          map = new google.maps.Map(document.getElementById("displayAddress"), {
          center: officeLocation,
          scrollwheel : false,
          zoom: 16
        });
          var marker = new google.maps.Marker({
          position: officeLocation,
          map: map,
          title: 'Find us here!'
        });
    
          var popupAddress = "22 Plumbers Row<br />";
              popupAddress += "Aldgate East<br />";
              popupAddress += "London<br />";
              popupAddress += "E1 1EZ<br />";
          
              
          var infowindow = new google.maps.InfoWindow({
          content: popupAddress,
          maxWidth: 300
        });
          marker.addListener('click', function() {
          infowindow.open(map, marker);
        });
    }
        
    function textAddress() {
        
        document.getElementById("displayAddress").innerHTML = "<h5>Just IT Training &amp; Recruitment</h5> 2nd Floor<br>St. Clare House<br>30-33 Minories<br>London EC3N 1DD<br><br><h5>Just IT Apprenticeships</h5>22 Plumbers Row<br>Aldgate East<br>London E1 1EZ"; 
    }

