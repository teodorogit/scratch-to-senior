<template>
    <div id="burguer-table">
        <mensagem-component :msg="msg" v-show="msg" />
        <div>
            <div id="burger-table-heading">
                <div class="order-id">#:</div>
                <div>Cliente:</div>
                <div>Pão:</div>
                <div>Carne:</div>
                <div>Opcionais:</div>
                <div>Ações:</div>
            </div>
        </div>
        <div id="burger-table-rows">
            <div class="burger-table-row" v-for="burger in burgers" :key="burger.id">
                <div class="order-number">{{ burger.id }}</div>
                <div>{{ burger.nome }}</div>
                <div>{{ burger.pao }}</div>
                <div>{{ burger.carne }}</div>
                <div>
                    <ul>
                        <li v-for="(opcional, index) in burger.opcionais" :key="index">{{ opcional }}</li>
                    </ul>
                </div>
                <div>
                    <select name="status" class="status" @change="updateBurger($event, burger.id)">
                        <option value="">Selecione o Status</option>
                        <option v-for="s in status" :key="s.id" :value="s.tipo" :selected="burger.status == s.tipo">
                            {{ s.tipo }}
                        </option>
                    </select>
                    <button class="delete-btn" @click="deleteBurger(burger.id)">Cancelar</button>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
import MensagemComponent from "../MensagemComponent/MensagemComponent.vue";
import { collection, getDocs, deleteDoc, doc, updateDoc, query, where } from "firebase/firestore";
import { db } from "../../firebase"; // Ajuste o caminho conforme necessário

export default {
    components: { MensagemComponent },
    name: "Dashboard",
    data() {
        return {
            burgers: [],
            status: [],
            msg: null,
            pedidos: [],
            error: null,
        };
    },
    methods: {
        // async getPedidos() {
        //     const req = await fetch("http://localhost:3000/burgers");
        //     const data = await req.json();
        //     this.burgers = data;

        //     //resgatar os status
        //     this.getStatus();
        // },
        async getPedidos() {
            try {
                const querySnapshot = await getDocs(collection(db, "burgers"));
                this.burgers = querySnapshot.docs.map((doc) => ({
                    id: doc.id,
                    ...doc.data(),
                }));

                // Resgatar os status
                this.getStatus();
            } catch (error) {
                console.error("Erro ao buscar pedidos:", error);
            }
        },

        // async getStatus() {
        //     const req = await fetch("http://localhost:3000/status");

        //     const data = await req.json();

        //     this.status = data;
        // },

        // async getStatus() {
        //     try {
        //         const querySnapshot = await getDocs(collection(db, 'status'));
        //         this.status = querySnapshot.docs.map(doc => ({
        //             id: doc.id,
        //             ...doc.data()
        //         }));
        //     } catch (error) {
        //         console.error('Erro ao buscar status:', error);
        //     }
        // },
        async getStatus() {
            try {
                const querySnapshot = await getDocs(collection(db, "status"));
                this.status = querySnapshot.docs.map((doc) => ({
                    id: doc.id,
                    ...doc.data(),
                }));
            } catch (error) {
                console.error("Erro ao buscar status:", error);
            }
        },

        // async deleteBurger(id) {
        //     const req = await fetch(`http://localhost:3000/burgers/${id}`, {
        //         method: "DELETE",
        //     });

        //     const res = await req.json();

        //     //msg
        //     this.msg = `Pedido Nº ${res.id} deletado`;
        //     setTimeout(() => {
        //         this.msg = "";
        //     }, 3000);
        //     this.getPedidos();
        // },
        async deleteBurger(id) {
            try {
                await deleteDoc(doc(db, "burgers", id));

                // Mensagem
                this.msg = `Pedido Nº ${id} deletado`;
                setTimeout(() => (this.msg = ""), 3000);
                this.getPedidos(); // Atualize a lista após a exclusão
            } catch (error) {
                console.error("Erro ao deletar pedido:", error);
            }
        },
        //     async updateBurger(event, id) {
        //         const option = event.target.value;
        //         const dataJson = JSON.stringify({ status: option });

        //         const req = await fetch(`http://localhost:3000/burgers/${id}`, {
        //             method: "PATCH",
        //             headers: { "Content-Type": "application/json" },
        //             body: dataJson,
        //         });
        //         const res = await req.json();
        //         this.msg = `O pedido ${res.id} foi atualizado para ${res.status}`;
        //         setTimeout(() => (this.msg = ""), 3000);
        //     },
        // },
        async updateBurger(event, id) {
            try {
                const option = event.target.value;
                const burgerRef = doc(db, "burgers", id);
                await updateDoc(burgerRef, { status: option });

                this.msg = `O pedido ${id} foi atualizado para ${option}`;
                setTimeout(() => (this.msg = ""), 3000);
            } catch (error) {
                console.error("Erro ao atualizar pedido:", error);
            }
        },
    },
    mounted() {
        this.getPedidos();
    },
};
</script>
<style scoped>
#burger-table {
    max-width: 1200px;
    margin: 0 auto;
}
#burger-table-heading,
#burger-table-rows,
.burger-table-row {
    display: flex;
    flex-wrap: wrap;
}

#burger-table-heading {
    font-weight: bold;
    padding: 12px;
    border-bottom: 3px solid #333;
}
#burger-table-heading div,
.burger-table-row div {
    width: 19%;
}
.burger-table-row {
    width: 100%;
    padding: 12px;
    border-bottom: 1px solid #ccc;
}
#burger-table-heading .order-id,
.burger-table-row .order-number {
    width: 5%;
}
select {
    padding: 12px 6px;
    margin-right: 12px;
}
.delete-btn {
    background-color: #222;
    color: #fcba03;
    font-weight: bold;
    border: 2px solid #333;
    padding: 10px;
    font-size: 16px;
    margin: 0 auto;
    cursor: pointer;
    transition: 0.5s;
}

.delete-btn:hover {
    background-color: transparent;
    color: #222;
}
</style>
