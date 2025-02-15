import {Component} from "react";
class Category extends Component{
    render(){
        return <div>
            <h3>Category Details:</h3>
            <p>
                <label>CategoryName:<b>{this.props.Cname}</b></label>
            </p>
        </div>
    }
}
export default Category;