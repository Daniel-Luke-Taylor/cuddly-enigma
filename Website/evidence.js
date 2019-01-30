function checkItem(iNames) {
    //check all names
    console.log(iNames);
    for (var i = 0; i < iNames.length; i++) {
        //read cookies
        var cokie = getCookie(iNames[i])
        if(cokie){
            //display hiddenobjects
            var obj = document.getElementById(iNames[i]);
            if(obj){
                obj.style.display = "block";
            }
            //remove collected items
            var obj = document.getElementById("item");
            if(obj){
                obj.parentNode.removeChild(obj);
            }
        }
    }
}

function getItem(iName) {
    //add item cookie
    document.cookie = iName + "=true; path=/";
    console.log("pickup" + iName);
    //removes item
    var obj = document.getElementById("item");
    obj.parentNode.removeChild(obj);
}

function getCookie(cname) {
  var name = cname + "=";
  var decodedCookie = decodeURIComponent(document.cookie);
  var ca = decodedCookie.split(';');
  for(var i = 0; i <ca.length; i++) {
    var c = ca[i];
    while (c.charAt(0) == ' ') {
      c = c.substring(1);
    }
    if (c.indexOf(name) == 0) {
      return c.substring(name.length, c.length);
    }
  }
  return "";
}
