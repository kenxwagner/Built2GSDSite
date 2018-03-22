import React from 'react'
import ReactDOM from 'react-dom'

class HelloWorld extends React.Component {
  render() {
    return (
      <div>Howdy!</div>
    )
  }
}

ReactDOM.render(<HelloWorld />, document.getElementById('root'));