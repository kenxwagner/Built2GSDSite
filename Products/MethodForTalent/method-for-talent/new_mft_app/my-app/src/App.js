import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <p className="App-intro">
          Study and learn more. This is a quick lesson. We are editing <code>src/App.js</code> and saving to reload.
        </p>
		<p className="Fakestuff">
		Fake Stuff to test code.</p>
		<p> What is next</p>
      </div>
	 
    );
  }
  
}

export default App;
