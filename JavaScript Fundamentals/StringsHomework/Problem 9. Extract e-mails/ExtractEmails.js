var text = 'My name is John and my e-mail is johnny@gmail.com. My brother\'s e-mail is Cooper_the_king89@yahoo.com. Other emails: queenB!@mail.com, stunna%@billy.bg'

console.log(extractEmailsFromText(text));

function extractEmailsFromText(text) {
    return text.match(/\w+@[A-z0-9]+\.[A-z0-9]+/gi);
}