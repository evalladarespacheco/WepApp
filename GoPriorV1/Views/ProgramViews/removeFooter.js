var child_footers = document.getElementsByTagName("footer");


while (child_footers.length > 0) {
    var footer_child = child_footers[0];
    var footer_parent = footer_child.parentNode;
    footer_parent.removeChild(footer_child);
}
