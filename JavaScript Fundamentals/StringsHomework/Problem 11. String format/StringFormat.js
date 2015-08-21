var frmt = '{2}, {1}, {3}, {0}, {0}, {1}, {3}',
    zero = 'Zero'
    one = 'One',
    two = 'Two',
    three = "Three";

console.log(stringFormat(frmt, zero, one, two, three))

function stringFormat(){
    var args = arguments,
    string = args[0],
    placeholder;

    for (var ind = 1; ind < args.length; ind++) {
        placeholder ='{' + (ind - 1) + '}';
		
        while(string.indexOf(placeholder) > -1) {
            string = string.replace(placeholder, args[ind]);
        }
    }

    return string;
}