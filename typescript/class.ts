class Product
{
   private id:number;
    proname:string;
    proprice:number;
    readonly qty:number;

    constructor(id:number,proname:string,proprice:number,quantity:number)
    {
        this.id = id;
        this.proname = proname;
        this.proprice = proprice;
        this.qty=quantity;
    }
    
    Display()
    {
        return `${this.id} ${this.proname} ${this.proprice} ${this.qty}`;
    }
}
let produ = new Product(1,'mobile',8000,4)
//produ.qty=5;
console.log(produ.Display());


