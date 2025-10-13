import React from 'react';

function Footer(props){
  return (
    <footer className="footer">
      <p>Zapraszamy codziennie od {props.companyInfo.openingHour} do {props.companyInfo.closingHour}</p>
      <p>© {props.companyInfo.established} {props.companyInfo.name} - Twój partner w motoryzacji</p>
    </footer>
  );
};

export default Footer;