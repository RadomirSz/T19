import PropTypes from "prop-types";
import React from "react";

const MyInput = props => {
    const { type, label, name, value, className, onChange } = props;
    return (
        <div>
            <label htmlFor={name}>{label}:</label>
            <input
                name={name}
                id={name}
                type={type}
                value={value}
                className={className}
                onChange={onChange}
            />
        </div>
    );
};

MyInput.propTypes = {
    label: PropTypes.string.isRequired,
    name: PropTypes.string.isRequired,
    value: PropTypes.string,
    type: PropTypes.string,
    className: PropTypes.string,
    onChange: PropTypes.func
};

export default MyInput;