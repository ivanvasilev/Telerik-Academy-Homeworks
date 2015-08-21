var inside = [1, 1], outside = [8, 8];

console.log(isInside(inside[0], inside[1], 0, 0, 5));
console.log(isInside(outside[0], outside[1], 0, 0, 5));

function isInside(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}