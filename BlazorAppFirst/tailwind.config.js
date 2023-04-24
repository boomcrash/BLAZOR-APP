/** @type {import('tailwindcss').Config} */
//const colors = require('tailwindcss/colors')
module.exports = {
  prefix:"tw-",
  content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            //Los colores utilizados en la página
            colors: {
                primary: {
                    DEFAULT: '#5e90e3',
                    light: '#93c5fd',//colors.blue[300],
                    dark: '#3730a3',//colors.indigo[400],
                    night: {
                        DEFAULT: '#0ea5e9',//colors.blue[500],
                        dark: '#0284c7',//colors.blue[600]
                    }
                },
                secondary: {
                    DEFAULT: '#de4c67',
                    light: '#f87171',//colors.red[400],
                    dark: '#dc2626',//colors.red[600],
                    night: {
                        DEFAULT: '#b91c1c',//colors.red[700],
                        dark: '#991b1b',//colors.red[800],
                        light: '#dc2626',//colors.red[600],
                    },
                },
                bground: {
                    DEFAULT: '#f5f5f5',//colors.neutral[50],
                    light: '#fafafa',
                    dark: '#e2e8f0',//colors.neutral[100],
                    night: {
                        DEFAULT: '#374151',//colors.gray[700],
                        dark:'#1f2937',//colors.gray[800],
                        light: '#4b5563',//colors.gray[600],,
                    },
                },
            },
            fontFamily: {
                'inria-sans': ['Inria Sans'],
                inter: ['Inter'],
                silkscreen: [],
            },
        },
    },
    plugins: [],
}

