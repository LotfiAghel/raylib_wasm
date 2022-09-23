var msgs = []
function addLog(tag, msg) {
  msgs.push(msg)
}

function reloadPage() {
  location.reload();
}

function clearLog(tag) {
  msgs = []
}
