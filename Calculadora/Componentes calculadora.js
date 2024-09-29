// src/components/Calculator.js
import React, { useState } from 'react';
import Button from './Button';

const Calculator = () => {
    const [input, setInput] = useState('');

    const handleButtonClick = (value) => {
        if (value === '=') {
            try {
                setInput(eval(input).toString());
            } catch {
                setInput('Error');
            }
        } else if (value === 'C') {
            setInput('');
        } else {
            setInput(input + value);
        }
    };

    const buttons = [
        '7', '8', '9', '/',
        '4', '5', '6', '*',
        '1', '2', '3', '-',
        'C', '0', '=', '+'
    ];

    return (
        <div className="calculator">
            <div className="display">{input}</div>
            <div className="button-container">
                {buttons.map((button, index) => (
                    <Button key={index} label={button} onClick={() => handleButtonClick(button)} />
                ))}
            </div>
        </div>
    );
};

export default Calculator;
