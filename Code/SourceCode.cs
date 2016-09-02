namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = root.GetComponent<Space>(); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				} else { UnityEngine.Debug.Log("prop2 != null = false " ); }
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				} else { UnityEngine.Debug.Log("ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " ); }
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Space subContext5 = root.GetComponent<Space>(); //IsContext = True IsNew = False
				
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = loc.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext9 != null)
								{
									GODelegate Lambda10 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													SpaceMarker subContext11 = AddContext9.GetComponent<SpaceMarker>(); //IsContext = True IsNew = False
													
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = subContext12.GetComponent<Place>(); //IsContext = False IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																} else { UnityEngine.Debug.Log("StoredVariable13 != null = false " ); }
																subContext12.Detach( (OperandVar14));
															} else { UnityEngine.Debug.Log("subContext12 != null = false " ); }
														}
													} else { UnityEngine.Debug.Log("subContext11 != null = false " ); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " ); }
										}
									};
									AddContext9.OnDestruction(Lambda10);
								} else { UnityEngine.Debug.Log("AddContext9 != null = false " ); }
							}
							Place AddContext15 = loc.AddComponent<Place>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext15 != null)
								{
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop16 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									AddContext15.Size = (System.Int32)( (OperandVar17));
								} else { UnityEngine.Debug.Log("AddContext15 != null = false " ); }
							}
							Named AddContext18 = loc.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext18 != null)
								{
									
									
									
									
									
									System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
									System.String prop19 = External.RandomName(); //IsContext = False IsNew = False
									if(prop19 != null)
									{
										OperandVar20 = prop19;
									} else { UnityEngine.Debug.Log("prop19 != null = false " ); }
									AddContext18.Set( ("main_name"), ("_1"),( ( ("Location of "))) + ( ( (OperandVar20))));
								} else { UnityEngine.Debug.Log("AddContext18 != null = false " ); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar22 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable21 = loc.GetComponent<Place>(); //IsContext = False IsNew = False
						if(StoredVariable21 != null)
						{
							OperandVar22 = StoredVariable21;
						} else { UnityEngine.Debug.Log("StoredVariable21 != null = false " ); }
						subContext5.Attach( (OperandVar22));
					}
				} else { UnityEngine.Debug.Log("subContext5 != null = false " ); }
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar37 = default(System.Boolean); //IsContext = False IsNew = False
			Card StoredVariable23 = root.GetComponent<Card>(); //IsContext = False IsNew = False
			if(StoredVariable23 != null)
			{
				UiObject StoredVariable24 = StoredVariable23.GetComponent<UiObject>(); //IsContext = False IsNew = False
				if(StoredVariable24 != null)
				{
					System.Boolean ifResult25; //IsContext = False IsNew = False
					
					System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop26 = StoredVariable24.ShowedObject; //IsContext = False IsNew = False
					if(prop26 != null)
					{
						System.Boolean ifResult27; //IsContext = False IsNew = False
						System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
						Named OperandVar29 = default(Named); //IsContext = False IsNew = False
						Named StoredVariable28 = prop26.GetComponent<Named>(); //IsContext = False IsNew = False
						if(StoredVariable28 != null)
						{
							OperandVar29 = StoredVariable28;
						} else { UnityEngine.Debug.Log("StoredVariable28 != null = false " ); }
						System.Boolean prop30 = External.Has( (OperandVar29)); //IsContext = False IsNew = False
						OperandVar31 = prop30;
						if(ifResult27 =  (OperandVar31))
						{
							OperandVar32 = ifResult27;
						} else { UnityEngine.Debug.Log("ifResult27 =  (OperandVar31) = false " ); }
					} else { UnityEngine.Debug.Log("prop26 != null = false " ); }
					
					System.Boolean OperandVar36 = default(System.Boolean); //IsContext = False IsNew = False
					Blackboards.named_ui_marker OperandVar34 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
					Blackboards.named_ui_marker StoredVariable33 = root.GetComponent<Blackboards.named_ui_marker>(); //IsContext = False IsNew = False
					if(StoredVariable33 != null)
					{
						OperandVar34 = StoredVariable33;
					} else { UnityEngine.Debug.Log("StoredVariable33 != null = false " ); }
					System.Boolean prop35 = External.Has( (OperandVar34)); //IsContext = False IsNew = False
					OperandVar36 = prop35;
					if(ifResult25 = ( ( (OperandVar32))) && ( (!(OperandVar36))))
					{
						applicable = true;
						OperandVar37 = applicable;
					} else { UnityEngine.Debug.Log("ifResult25 = ( ( (OperandVar32))) && ( (!(OperandVar36))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable24 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable23 != null = false " ); }
			return (System.Boolean) (OperandVar37);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.named_ui_marker>();
			root.AddComponent<TextField>();
			
			{
				TextField subContext38 = root.GetComponent<TextField>(); //IsContext = True IsNew = False
				
				if(subContext38 != null)
				{
					System.String OperandVar43 = default(System.String); //IsContext = False IsNew = False
					Card StoredVariable39 = root.GetComponent<Card>(); //IsContext = False IsNew = False
					if(StoredVariable39 != null)
					{
						UnityEngine.GameObject prop40 = StoredVariable39.ShowedObject; //IsContext = False IsNew = False
						if(prop40 != null)
						{
							Named StoredVariable41 = prop40.GetComponent<Named>(); //IsContext = False IsNew = False
							if(StoredVariable41 != null)
							{
								
								System.String prop42 = StoredVariable41.Get( ("main_name")); //IsContext = False IsNew = False
								if(prop42 != null)
								{
									OperandVar43 = prop42;
								} else { UnityEngine.Debug.Log("prop42 != null = false " ); }
							} else { UnityEngine.Debug.Log("StoredVariable41 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop40 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable39 != null = false " ); }
					subContext38.Set( (OperandVar43));
				} else { UnityEngine.Debug.Log("subContext38 != null = false " ); }
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar49 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable44 = root.GetComponent<Place>(); //IsContext = False IsNew = False
			if(StoredVariable44 != null)
			{
				GenerateMarker StoredVariable45 = StoredVariable44.GetComponent<GenerateMarker>(); //IsContext = False IsNew = False
				if(StoredVariable45 != null)
				{
					System.Boolean ifResult46; //IsContext = False IsNew = False
					
					System.Collections.Generic.List<Agent> OperandVar48 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					if(StoredVariable44 != null)
					{
						System.Collections.Generic.List<Agent> prop47 = StoredVariable44.Agents; //IsContext = False IsNew = False
						if(prop47 != null)
						{
							OperandVar48 = prop47;
						} else { UnityEngine.Debug.Log("prop47 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable44 != null = false " ); }
					
					
					if(ifResult46 = ( ( (OperandVar48 != null ? OperandVar48.Count : 0))) == ( ( (0f))))
					{
						applicable = true;
						OperandVar49 = applicable;
					} else { UnityEngine.Debug.Log("ifResult46 = ( ( (OperandVar48 != null ? OperandVar48.Count : 0))) == ( ( (0f))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable45 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable44 != null = false " ); }
			return (System.Boolean) (OperandVar49);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Place subContext50 = root.GetComponent<Place>(); //IsContext = True IsNew = False
				
				if(subContext50 != null)
				{
					
					subContext50.Size = (System.Int32)( (5f));
					System.Single OperandVar52 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop51 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar52 = prop51;
					for (int i = 0; i <  (OperandVar52); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag53 = ag; //IsContext = True IsNew = False
							Entity AddContext54 = ag.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext54 != null)
								{
									GODelegate Lambda55 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													PlaceMarker subContext56 = AddContext54.GetComponent<PlaceMarker>(); //IsContext = True IsNew = False
													
													if(subContext56 != null)
													{
														
														{
															Place subContext57 = subContext56.CurrentPlace; //IsContext = True IsNew = False
															
															if(subContext57 != null)
															{
																Agent OperandVar59 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable58 = subContext57.GetComponent<Agent>(); //IsContext = False IsNew = False
																if(StoredVariable58 != null)
																{
																	OperandVar59 = StoredVariable58;
																} else { UnityEngine.Debug.Log("StoredVariable58 != null = false " ); }
																subContext57.Detach( (OperandVar59));
															} else { UnityEngine.Debug.Log("subContext57 != null = false " ); }
														}
													} else { UnityEngine.Debug.Log("subContext56 != null = false " ); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " ); }
										}
									};
									AddContext54.OnDestruction(Lambda55);
								} else { UnityEngine.Debug.Log("AddContext54 != null = false " ); }
							}
							Agent AddContext60 = ag.AddComponent<Agent>(); //IsContext = True IsNew = True
							Blackboards.human AddContext61 = ag.AddComponent<Blackboards.human>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext61 != null)
								{
									System.Single OperandVar63 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop62 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar63 = prop62;
									AddContext61.Age = (System.Int32)( (OperandVar63));
								} else { UnityEngine.Debug.Log("AddContext61 != null = false " ); }
							}
							Named AddContext64 = ag.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext64 != null)
								{
									
									
									System.String OperandVar66 = default(System.String); //IsContext = False IsNew = False
									System.String prop65 = External.RandomName(); //IsContext = False IsNew = False
									if(prop65 != null)
									{
										OperandVar66 = prop65;
									} else { UnityEngine.Debug.Log("prop65 != null = false " ); }
									AddContext64.Set( ("main_name"), ("_1"), (OperandVar66));
								} else { UnityEngine.Debug.Log("AddContext64 != null = false " ); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar68 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable67 = ag.GetComponent<Agent>(); //IsContext = False IsNew = False
						if(StoredVariable67 != null)
						{
							OperandVar68 = StoredVariable67;
						} else { UnityEngine.Debug.Log("StoredVariable67 != null = false " ); }
						subContext50.Attach( (OperandVar68));
					}
				} else { UnityEngine.Debug.Log("subContext50 != null = false " ); }
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar75 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable69 = root.GetComponent<Place>(); //IsContext = False IsNew = False
			if(StoredVariable69 != null)
			{
				System.Boolean ifResult70; //IsContext = False IsNew = False
				System.Boolean OperandVar74 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar72 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable71 = StoredVariable69.GetComponent<Blackboards.event_marker>(); //IsContext = False IsNew = False
				if(StoredVariable71 != null)
				{
					OperandVar72 = StoredVariable71;
				} else { UnityEngine.Debug.Log("StoredVariable71 != null = false " ); }
				System.Boolean prop73 = External.Has( (OperandVar72)); //IsContext = False IsNew = False
				OperandVar74 = prop73;
				if(ifResult70 = !(OperandVar74))
				{
					applicable = true;
					OperandVar75 = applicable;
				} else { UnityEngine.Debug.Log("ifResult70 = !(OperandVar74) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable69 != null = false " ); }
			return (System.Boolean) (OperandVar75);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.event_marker>();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar82 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable76 = root.GetComponent<Agent>(); //IsContext = False IsNew = False
			if(StoredVariable76 != null)
			{
				System.Boolean ifResult77; //IsContext = False IsNew = False
				System.Boolean OperandVar81 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar79 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable78 = StoredVariable76.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable78 != null)
				{
					OperandVar79 = StoredVariable78;
				} else { UnityEngine.Debug.Log("StoredVariable78 != null = false " ); }
				System.Boolean prop80 = External.Has( (OperandVar79)); //IsContext = False IsNew = False
				OperandVar81 = prop80;
				if(ifResult77 = !(OperandVar81))
				{
					applicable = true;
					OperandVar82 = applicable;
				} else { UnityEngine.Debug.Log("ifResult77 = !(OperandVar81) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable76 != null = false " ); }
			return (System.Boolean) (OperandVar82);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			Blackboards.personality ContextVar83 = root.AddComponent<Blackboards.personality>();; //IsContext = False IsNew = True
			
			{
				
				if(ContextVar83 != null)
				{
					System.Single OperandVar85 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop84 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar85 = prop84;
					ContextVar83.Cruelty = (System.Single)( (OperandVar85));
					System.Single OperandVar87 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop86 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar87 = prop86;
					ContextVar83.Rationality = (System.Single)( (OperandVar87));
					System.Single OperandVar89 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop88 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar89 = prop88;
					ContextVar83.Generosity = (System.Single)( (OperandVar89));
					System.Single OperandVar91 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop90 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar91 = prop90;
					ContextVar83.Zealotry = (System.Single)( (OperandVar91));
				} else { UnityEngine.Debug.Log("ContextVar83 != null = false " ); }
			}
		}
        }
    }
    
    public class send_team_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar99 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable92 = root.GetComponent<Place>(); //IsContext = False IsNew = False
			if(StoredVariable92 != null)
			{
				Blackboards.event_marker StoredVariable93 = StoredVariable92.GetComponent<Blackboards.event_marker>(); //IsContext = False IsNew = False
				if(StoredVariable93 != null)
				{
					System.Boolean ifResult94; //IsContext = False IsNew = False
					System.Boolean OperandVar98 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar96 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop95 = StoredVariable93.CurEvent; //IsContext = False IsNew = False
					if(prop95 != null)
					{
						OperandVar96 = prop95;
					} else { UnityEngine.Debug.Log("prop95 != null = false " ); }
					System.Boolean prop97 = External.Has( (OperandVar96)); //IsContext = False IsNew = False
					OperandVar98 = prop97;
					if(ifResult94 =  (OperandVar98))
					{
						applicable = true;
						OperandVar99 = applicable;
					} else { UnityEngine.Debug.Log("ifResult94 =  (OperandVar98) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable93 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable92 != null = false " ); }
			return (System.Boolean) (OperandVar99);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Blackboards.event_marker subContext100 = root.GetComponent<Blackboards.event_marker>(); //IsContext = True IsNew = False
				
				if(subContext100 != null)
				{
					
					{
						UnityEngine.GameObject subContext101 = subContext100.CurEvent; //IsContext = True IsNew = False
						
						if(subContext101 != null)
						{
							subContext101.AddComponent<Event>();
						} else { UnityEngine.Debug.Log("subContext101 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("subContext100 != null = false " ); }
			}
		}
        }
    }
}
