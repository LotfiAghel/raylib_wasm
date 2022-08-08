var msgs = []
function addLog(tag, msg) {
  msgs.push(msg)
}

function clearLog(tag) {
  msgs = []
}
/*
window.wsConnect2  =async function(url) {

  
  console.log("-------------------------------abcd------------------------")

  //window.location.hash get after # in url
  URL = url
  socket = new WebSocket(url);
  socket.onopen = function (e) {

    connected = true
  };

  socket.onmessage = function (event) {

    var ptr = allocate(intArrayFromString(event.data), ALLOC_NORMAL);

    // Call the method passing the pointer

    try {
      Module['asm']["wssRecive"](ptr)
    } catch {

    }

    _free(ptr);

  };
}

var downloadAndSave = async function (path, pid) {
  alert(1)
  createDir(path)

  var response = await fetch(path, { credentials: 'same-origin' });
  var a = await response['arrayBuffer']()
  try {
    Module.print("get " + path)
    FS.writeFile(path, new Uint8Array(a))
  } catch {
    Module.print("------------------cant save----------------" + path)
  }
  //wasmI.instance.exports.endDownload(pid)
  Module['asm']["endDownload"](pid)


}

var URL = ""
let socket = 0;//new WebSocket("ws://localhost:9001/ws");

var connected = false


socket.onclose = function (event) {
  connected = false
  if (event.wasClean) {
    //alert(`[close] Connection closed cleanly, code=${event.code} reason=${event.reason}`);
  } else {
    // e.g. server process killed or network down
    // event.code is usually 1006 in this case
    //alert('[close] Connection died');
  }
  let socket = new WebSocket(URL);
};

socket.onerror = function (error) {
  alert(`[error] ${error.message}`);
};
var wsSend = async function (msg) {
  console.log(msg);
  socket.send(msg);
}*/