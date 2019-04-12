//'use strict';

//const el = React.createElement;

//class LikeButton extends React.Component {
//    constructor(props) {
//        super(props);
//        this.state = { liked: false };
//    }

//    render() {
//        if (this.state.liked) {
//            return 'You liked this.';
//        }

//        return el(
//            'button',
//            { onClick: () => this.setState({ liked: true }) },
//            'Like'
//        );
//    }
//}



class HelloWithState extends React.Component {

    constructor(props) {
        //Since we are extending the default constructor,
        //handle default activities first.
        super(props);

        //Extract the firstname from the prop
        let firstName = this.props.name.split(" ")[0];
        //Please don't judge me by the way I extract the first name.
        //This is an example.

        //In the constructor, feel free to modify the
        //state property on the current context.
        this.state = {
            name: firstName
        };

    } //Look maa, no comma required in JSX based class defs!

    render() {
        return '<h1>Hello,{'+this.state.name+'}!</h1>';
    }
}



ReactDOM.render(<HelloWithState name="Billy James" />,
    document.getElementById('reacttestdiv'));
