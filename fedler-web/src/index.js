import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.scss';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { createBrowserRouter, Navigate, RouterProvider } from 'react-router-dom';
import Feed from './routes/Feed';
import Feeds from './routes/Feeds';

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        path: "",
        element: <Navigate to="feeds" replace={true} />
      },
      {
        path: "feeds",
        element: <Feeds />,
      },
      {
        path: "feeds/:feedId",
        element: <Feed />,
      },
    ]
  },
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);

reportWebVitals(console.log);
