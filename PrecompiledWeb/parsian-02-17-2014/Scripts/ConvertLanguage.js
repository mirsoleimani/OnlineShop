var farsi = true;
var s = new Array(32, 33, 34, 35, 36, 37, 1548, 1711, 41, 40, 215, 43, 1608, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 1603, 44, 61, 46, 1567, 64, 1616, 1584, 125, 1609, 1615, 1609, 1604, 1570, 247, 1600, 1548, 47, 8217, 1583, 215, 1563, 1614, 1569, 1613, 1601, 8216, 123, 1611, 1618, 1573, 126, 1580, 1688, 1670, 94, 95, 1662, 1588, 1584, 1586, 1610, 1579, 1576, 1604, 1575, 1607, 1578, 1606, 1605, 1574, 1583, 1582, 1581, 1590, 1602, 1587, 1601, 1593, 1585, 1589, 1591, 1594, 1592, 60, 124, 62, 1617);
var b = navigator.userAgent.toLowerCase();
var msie = (b.indexOf('msie') > -1) ? true : false;
var gecko = (b.indexOf('gecko') > -1) ? true : false;
var opera = (b.indexOf('opera') > -1) ? true : false;
function convert(fld, e) {
    k = (msie) ? event.keyCode : e.which;
    if (farsi) {
        if (msie && k > 32 && k < 128) event.keyCode = s[k - 32];
        else if (gecko && k > 32 && k < 128) {
            var EVT = document.createEvent("KeyEvents");
            EVT.initKeyEvent("keypress", true, true, document.defaultView, e.ctrlKey, e.altKey, e.shiftKey, e.metaKey, 0, String.fromCharCode(s[k - 32]).charCodeAt(0));
            e.preventDefault();
            e.target.dispatchEvent(EVT);
        }
        else if (opera && k > 31 && k < 128) {
            fld.value = fld.value + String.fromCharCode(s[k - 32]);
            return false;
        }
    }
}
function LangFar(myobj) {
    myobj.style.textAlign = "right";
    myobj.style.direction = "rtl";
    myobj.focus();
}
function LangEng(myobj) {
    myobj.style.textAlign = "left";
    myobj.style.direction = "ltr";
    myobj.focus();
}
function change(obj) {
    farsi = !farsi;
    obj.focus();
}