var people = [{ name: 'Jimmy', age: 20 },
              { name: 'Billy', age: 18 },
              { name: 'Lilly', age: 22 }],
    template = '<strong>-{name}-</strong> <span>-{age}-</span>';

console.log(generateList(people, template))

function generateList(people, template) {
    var result = '<ul>',
        i;
    for (i = 0; i < people.length; i += 1) {
        result += '<li>';
        result += template.replace('-{name}-', people[i]['name']).replace('-{age}-', people[i]['age']);
        result += '</li>';
    }
    result += '</ul>';

    return result;
}