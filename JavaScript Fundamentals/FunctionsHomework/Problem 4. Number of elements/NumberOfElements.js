function getNumberOfDivs() {
    return document.getElementsByTagName('div').length;
}

console.log('There are ' + getNumberOfDivs() + ' divs in the HTML!');