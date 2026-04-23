function ShapeGraphic(props) {
  const imageByShape = {
    stozek: {
      src: '/stozek.png',
      alt: 'Grafika stozka'
    },
    ostroslup: {
      src: '/ostroslup.png',
      alt: 'Grafika ostroslupa o podstawie kwadratu'
    }
  };

  const selectedImage = imageByShape[props.shape];

  if (!selectedImage) {
    return null;
  }

  return <img className="shape-graphic" src={selectedImage.src} alt={selectedImage.alt} />;
}

export default ShapeGraphic;
