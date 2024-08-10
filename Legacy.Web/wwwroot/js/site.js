const root = document.documentElement;

const chartNo = document.querySelector('.chart-no');
const chartYes = document.querySelector('.chart-yes');
const chartClientDoesntKnow = document.querySelector('.chart-client-doesnt-know');
const chartClientPrefersNotToSay = document.querySelector('.chart-client-prefers-not-to-say');
const chartNoAnswer = document.querySelector('.chart-no-answer');

const blue = 12.57;
const green = 81.68;
const yellow = .52;
const grey = 2.62;
const litePink = 2.62;

let blueStart = 0;
let blueEnd = blue;

let greenStart = blueEnd;
let greenEnd = blueEnd + green;

let yellowStart = greenEnd;
let yellowEnd = greenEnd + yellow;

let greyStart = yellowEnd;
let greyEnd = yellowEnd + grey;

let litePinkStart = greyEnd;
let litePinkEnd = greyEnd + litePink;

root.style.setProperty('--blueStart', blueStart + '%');
root.style.setProperty('--blueEnd', blueEnd + '%');

root.style.setProperty('--greenStart', greenStart + '%');
root.style.setProperty('--greenEnd', greenEnd + '%');

root.style.setProperty('--yellowStart', yellowStart + '%');
root.style.setProperty('--yellowEnd', yellowEnd + '%');

root.style.setProperty('--greyStart', greyStart + '%');
root.style.setProperty('--greyEnd', greyEnd + '%');

root.style.setProperty('--litePinkStart', litePinkStart + '%');
root.style.setProperty('--litePinkEnd', litePinkEnd + '%');

chartNo.innerHTML = blue + '% ';
chartYes.innerHTML = green + '% ';
chartClientDoesntKnow.innerHTML = yellow + '% ';
chartClientPrefersNotToSay.innerHTML = grey + '% ';
chartNoAnswer.innerHTML = litePink + '% ';
