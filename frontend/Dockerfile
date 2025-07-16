FROM node:18 AS build
WORKDIR /app

COPY package*.json ./
RUN npm install

COPY . .
RUN npm run build:ssr

# Runtime com Node.js
FROM node:18
WORKDIR /app
COPY --from=build /app/dist /app/dist

EXPOSE 4200
CMD ["node", "dist/server/main.js"]
