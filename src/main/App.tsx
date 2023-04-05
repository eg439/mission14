import React from 'react';
import '../main/App.css';
import TopBanner from '../blah';
import MovieList from '../movies/movieList';
import Podcasts from '../podcats';
import { BrowserRouter, Route, Link, Routes } from 'react-router-dom';
function App() {
  //routes for the seperate pages
  return (
    <>
      <BrowserRouter>
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/podcast">Podcast</Link>
            </li>
            <li>
              <Link to="/movieList">Movie List</Link>
            </li>
          </ul>
        </nav>
        <Routes>
          <Route path="/" Component={TopBanner} />
          <Route path="/podcast" Component={Podcasts} />
          <Route path="/movieList" Component={MovieList} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
