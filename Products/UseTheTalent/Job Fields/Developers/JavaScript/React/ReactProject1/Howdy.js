import React from 'react'
import ReactDOM from 'react-dom'

class HelloWorld extends React.Component {
  render() { return React.createElement("div", null, "Howdy!");
  }
}

ReactDOM.render(<HelloWorld />, document.getElementById('root'));