import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <h1>Just to get started, here is a Title: Built2GSD</h1>
		<p>
          So what is the plan?
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
         Welcome to the site
        </a>
      </header>
    </div>
  );
}

export default App;
