function saveNotes(){
    notebox = document.getElementById("notes").value;
    notecookie = notebox.replace(/(\r\n|\n|\r)/gm,"<newline>");
    document.cookie = "notepadcontent=" + notecookie + "; path=/";
    console.log("Save " + "notepadcontent=" + notecookie + "; path=/");
}

function loadNotes(){
    notecookie = getCookie("notepadcontent");
    loadednotes = notecookie.replace(/<newline>/gm,"\r\n");
    console.log("Load " + loadednotes);
    document.getElementById("notes").value = loadednotes;
}

//wcSchools read cookie function
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