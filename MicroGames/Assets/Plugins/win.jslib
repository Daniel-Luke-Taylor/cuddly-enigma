mergeInto(LibraryManager.library, {

    GetItem: function (iName) {
        //add item cookie
        document.cookie = Pointer_stringify(iName) + "=true; path=/";
        console.log("pickup" + Pointer_stringify(iName));
        console.log(typeof Pointer_stringify(iName));
    },
    
    GotoLink: function () {
        window.location.href = "../casefile.html";
    },
    
    GotoBook: function () {
        window.location.href = "../book.html";
    },
  
  });