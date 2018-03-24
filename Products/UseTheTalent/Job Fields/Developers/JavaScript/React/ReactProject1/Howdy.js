import React from 'react'
import ReactDOM from 'react-dom'

class HelloWorld extends React.Component {
  render() { return React.createElement("div", null, "Howdy!");
  }
}

class HelloUser extends React.Component {
  constructor(props) {
    super(props)

    this.state = {
      username: 'Ticonderoga'
    }
  }
  render() {
    return (
      <div>
        Hello {this.state.username}
      </div>
    )
  }
}
