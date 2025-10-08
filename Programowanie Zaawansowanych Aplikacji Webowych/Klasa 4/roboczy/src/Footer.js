import React from 'react';

const Footer = ({ openingHours, companyName, year }) => {
  return (
    <footer className="footer">
      <p>{openingHours}</p>
      <p>© {year} {companyName} - Twój partner w motoryzacji</p>
    </footer>
  );
};

export default Footer;