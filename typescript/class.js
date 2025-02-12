var Product = /** @class */ (function () {
    function Product(id, proname, proprice, quantity) {
        this.id = id;
        this.proname = proname;
        this.proprice = proprice;
        this.qty = quantity;
    }
    Product.prototype.Display = function () {
        return "".concat(this.id, " ").concat(this.proname, " ").concat(this.proprice, " ").concat(this.qty);
    };
    return Product;
}());
var produ = new Product(1, 'mobile', 8000, 4);
console.log(produ.Display());
