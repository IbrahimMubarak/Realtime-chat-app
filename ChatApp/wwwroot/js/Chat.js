"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {

    $('#messagesList').append((user == $("#userInput").val()) ?'<li class="clearfix"><div class="message-data text-right" ><span class="message-data-time">' + Date(Date.now()).toString().substring(15, 21) + '</span></div><div class="message float-right "style="color:white;background-color: #0E86D4">' + message + '</div>'
        : '<li class="clearfix"><div class= "message-data" >' + Date(Date.now()).toString().substring(15, 21) + '</span ></div><div class="message" style="background: #e8f1f3"><h5 class="text-left" style="color:#0E86D4">'+user+'</h5>' + message + '</div></li >'
      );
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
 
});
//connection.on("Online", function (user) {

//    $('#users').append('<li class="clearfix">' +
//        '<div class="about"><div class="name">' + user + '</div>' +
//                        ' <div class="status"> <i class="fa fa-circle online"></i></div></div></li>');
//    // We can assign user-supplied strings to an element's textContent because it
//    // is not interpreted as markup. If you're assigning in any other way, you 
//    // should be aware of possible script injection concerns.

//});

$("#messageInput").keyup(function (event) {
    if (event.keyCode === 13) {
        $("#sendButton").click();
      
        
    }
});
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    document.getElementById("messageInput").value ="";
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
        
    });
    event.preventDefault();
});
window.setInterval(function () {
    var elem = document.getElementById('data');
    elem.scrollTop = elem.scrollHeight;
});


